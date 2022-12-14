using System.Text.RegularExpressions;
using ZH_AMRIGW.Model;

namespace ZH_AMRIGW
{
    public partial class Form1 : Form
    {
        vasarlasContext context = new vasarlasContext();
        public Form1()
        {
            InitializeComponent();
            listBoxTetel.DataSource = tetelBindingSource;
            //listBoxTetel.DisplayMember = "Nev";
            //listBoxTetel.ValueMember = "TetelId";
            updateTetel();

            listBoxVasarlas.DisplayMember = "Datum";
            listBoxVasarlas.ValueMember = "VasarlasId";
            updateVasarlas();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            updateDgv();

            comboBoxEgyseg.DataSource = (from x in context.Egyseg select x.Nev).ToList();

            buttonAddTetel.CausesValidation = true;
            buttonAdd.CausesValidation = true;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!(MessageBox.Show("Biztos ki szeretne lepni?", "Kilepes", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                e.Cancel = true;
            }
        }

        private void updateTetel()
        {
            tetelBindingSource.DataSource = (from x in context.Tetel where x.Nev.Contains(textBoxTetel.Text) select x).ToList();
        }

        private void textBoxTetel_TextChanged(object sender, EventArgs e)
        {
            updateTetel();
        }

        private void updateVasarlas()
        {
            try
            {
                listBoxVasarlas.DataSource = new List<Vasarlas> {((from x in context.Vasarlas where
                                          x.Datum.Year == dateTimePickerVasarlas.Value.Year &&
                                          x.Datum.Month == dateTimePickerVasarlas.Value.Month &&
                                          x.Datum.Day == dateTimePickerVasarlas.Value.Day
                                          select x).ToList()[0])};
                //A listBox szûrése megtörténik, de mivel napok alapján választjuk ki a vásárlásokat,
                //elég egyet megjeleníteni belõlük. De így is van funkciója szûrésnek, akartam csinálni egy range szûrést
                //és akkor ezzel a módszerrel meg lehetne jeleníteni egyszerre több napot is,
                //de mivel nem ért volna plusz pontot kihagytam
            }
            catch //ha a kivalasztott datumon meg nincs rekord (kulonben index out of range)
            {
                listBoxVasarlas.DataSource = (from x in context.Vasarlas
                                              where
                                          x.Datum.Year == dateTimePickerVasarlas.Value.Year &&
                                          x.Datum.Month == dateTimePickerVasarlas.Value.Month &&
                                          x.Datum.Day == dateTimePickerVasarlas.Value.Day
                                              select x).ToList();
            }




            updateDgv();
        }

        private void dateTimePickerVasarlas_ValueChanged(object sender, EventArgs e)
        {
            updateVasarlas();
        }

        private void updateDgv()
        {
            dataGridView1.DataSource = (from x in context.Vasarlas where
                                        x.Datum.Year == dateTimePickerVasarlas.Value.Year &&
                                          x.Datum.Month == dateTimePickerVasarlas.Value.Month &&
                                          x.Datum.Day == dateTimePickerVasarlas.Value.Day
                                        select new tetelesVasarlas()
                                        {
                                            Id = x.VasarlasId,
                                            Datum = x.Datum,
                                            TetelNev = x.TetelFkNavigation.Nev,
                                            Mennyiseg = x.Mennyiseg,
                                            Egyseg = x.TetelFkNavigation.EgysegFkNavigation.Nev,
                                            Egysegar = x.TetelFkNavigation.EgysegAr,
                                            Vegosszeg = x.Mennyiseg * x.TetelFkNavigation.EgysegAr
                                        }).ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            Vasarlas vasarlas = new Vasarlas();
            try
            {
                vasarlas.Datum = dateTimePickerVasarlas.Value;

                if (String.IsNullOrEmpty(textBoxMennyiseg.Text)) //egyszeru ellenorzes
                {
                    MessageBox.Show("A hozzaadas sikertelen volt! Valamelyik adat hibas.", "Hiba", MessageBoxButtons.OK);
                    return;
                }
                vasarlas.Mennyiseg = int.Parse(textBoxMennyiseg.Text);
                vasarlas.TetelFk = (int)listBoxTetel.SelectedValue;
            }
            catch
            {
                MessageBox.Show("A hozzaadas sikertelen volt! Valamelyik adat hibas.", "Hiba", MessageBoxButtons.OK);
                return;
            }

            if (!(MessageBox.Show("Biztosan szeretne hozzaadni az elemet?", "Hozzaadas", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }

            try
            {
                context.Vasarlas.Add(vasarlas);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("A hozzaadas sikertelen volt!", "Hiba", MessageBoxButtons.OK);
                return;
            }
            updateVasarlas();
            updateDgv();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Vasarlas torlendoVasarlas = new Vasarlas();
            torlendoVasarlas = (from x in context.Vasarlas where
                                x.VasarlasId == (int)dataGridView1.SelectedRows[0].Cells["Id"].Value 
                                select x).ToList()[0];
            if(!(MessageBox.Show("Biztosan szeretne torolni az elemet?", "Torles", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }
            try
            {
                context.Remove(torlendoVasarlas);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("A torles sikertelen volt!", "Hiba", MessageBoxButtons.OK);
                return;
            }
            updateDgv();
            updateVasarlas();
        }

        private void buttonAddTetel_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            Tetel tetel = new Tetel();
            try
            {
                if (String.IsNullOrEmpty(textBoxName.Text))//egyszeru ellenorzes
                {
                    MessageBox.Show("A hozzaadas sikertelen volt! Valamelyik adat hibas.", "Hiba", MessageBoxButtons.OK);
                    return;
                }
                tetel.Nev = textBoxName.Text;

                if (String.IsNullOrEmpty(textBoxEgysegar.Text)) //egyszeru ellenorzes
                {
                    MessageBox.Show("A hozzaadas sikertelen volt! Valamelyik adat hibas.", "Hiba", MessageBoxButtons.OK);
                    return;
                }
                tetel.EgysegAr = int.Parse(textBoxEgysegar.Text);
                tetel.EgysegFk = (from x in context.Egyseg where x.Nev == comboBoxEgyseg.Text select x.EgysegId).ToList()[0];
            }
            catch
            {
                MessageBox.Show("A hozzaadas sikertelen volt! Valamelyik adat hibas.", "Hiba", MessageBoxButtons.OK);
                return;
            }

            if (!(MessageBox.Show("Biztosan szeretne hozzaadni a tetelt?", "Hozzaadas", MessageBoxButtons.YesNo) == DialogResult.Yes))
            {
                return;
            }

            try
            {
                context.Tetel.Add(tetel);
                context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("A hozzaadas sikertelen volt!", "Hiba", MessageBoxButtons.OK);
                return;
            }
            updateTetel();
        }

        private void textBoxMennyiseg_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex r = new Regex("^[0-9]");
            if (!r.IsMatch(textBoxMennyiseg.Text))
            {
                buttonAdd.Enabled = false;
                errorProvider1.SetError(textBoxMennyiseg, "Szamot adjon meg!");
            }
        }

        private void textBoxMennyiseg_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]");
            if (r.IsMatch(textBoxMennyiseg.Text))
            {
                buttonAdd.Enabled = true;
                errorProvider1.SetError(textBoxMennyiseg, "");
            }
        }

        private void textBoxMennyiseg_TextChanged(object sender, EventArgs e)
        {
            this.ValidateChildren();
        }

        private void textBoxName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex r = new Regex("[a-zA-z0-9 ]");
            if (!r.IsMatch(textBoxName.Text))
            {
                buttonAddTetel.Enabled = false;
                errorProvider1.SetError(textBoxName, "A nevben szerepelnie kell alfanumerikus karakternek!");
            }

        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("[a-zA-z0-9 ]");
            if (r.IsMatch(textBoxName.Text))
            {
                buttonAddTetel.Enabled = true;
                errorProvider1.SetError(textBoxName, "");
            }
        }

        private void textBoxEgysegar_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex r = new Regex("^[0-9]");
            if (!r.IsMatch(textBoxEgysegar.Text))
            {
                buttonAddTetel.Enabled = false;
                errorProvider1.SetError(textBoxEgysegar, "Szamot adjon meg!");
            }
        }

        private void textBoxEgysegar_Validated(object sender, EventArgs e)
        {
            Regex r = new Regex("^[0-9]");
            if (r.IsMatch(textBoxEgysegar.Text))
            {
                buttonAddTetel.Enabled = true;
                errorProvider1.SetError(textBoxEgysegar, "");
            }
        }

        private void textBoxEgysegar_TextChanged(object sender, EventArgs e)
        {
            this.ValidateChildren();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            this.ValidateChildren();
        }

        private void listBoxTetel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}