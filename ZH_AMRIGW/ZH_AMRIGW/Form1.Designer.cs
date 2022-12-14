namespace ZH_AMRIGW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxTetel = new System.Windows.Forms.ListBox();
            this.tetelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tetelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxTetel = new System.Windows.Forms.TextBox();
            this.listBoxVasarlas = new System.Windows.Forms.ListBox();
            this.dateTimePickerVasarlas = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMennyiseg = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEgyseg = new System.Windows.Forms.ComboBox();
            this.buttonAddTetel = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEgysegar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tetelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTetel
            // 
            this.listBoxTetel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxTetel.DataSource = this.tetelBindingSource;
            this.listBoxTetel.DisplayMember = "Nev";
            this.listBoxTetel.FormattingEnabled = true;
            this.listBoxTetel.ItemHeight = 15;
            this.listBoxTetel.Location = new System.Drawing.Point(750, 49);
            this.listBoxTetel.Name = "listBoxTetel";
            this.listBoxTetel.Size = new System.Drawing.Size(120, 484);
            this.listBoxTetel.TabIndex = 0;
            this.listBoxTetel.ValueMember = "TetelId";
            this.listBoxTetel.SelectedIndexChanged += new System.EventHandler(this.listBoxTetel_SelectedIndexChanged);
            // 
            // tetelBindingSource
            // 
            this.tetelBindingSource.DataSource = typeof(ZH_AMRIGW.Model.Tetel);
            // 
            // tetelBindingSource1
            // 
            this.tetelBindingSource1.DataSource = typeof(ZH_AMRIGW.Model.Tetel);
            // 
            // textBoxTetel
            // 
            this.textBoxTetel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTetel.Location = new System.Drawing.Point(750, 20);
            this.textBoxTetel.Name = "textBoxTetel";
            this.textBoxTetel.Size = new System.Drawing.Size(120, 23);
            this.textBoxTetel.TabIndex = 1;
            this.textBoxTetel.TextChanged += new System.EventHandler(this.textBoxTetel_TextChanged);
            // 
            // listBoxVasarlas
            // 
            this.listBoxVasarlas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxVasarlas.FormattingEnabled = true;
            this.listBoxVasarlas.ItemHeight = 15;
            this.listBoxVasarlas.Location = new System.Drawing.Point(12, 49);
            this.listBoxVasarlas.Name = "listBoxVasarlas";
            this.listBoxVasarlas.Size = new System.Drawing.Size(135, 484);
            this.listBoxVasarlas.TabIndex = 2;
            // 
            // dateTimePickerVasarlas
            // 
            this.dateTimePickerVasarlas.Location = new System.Drawing.Point(12, 20);
            this.dateTimePickerVasarlas.Name = "dateTimePickerVasarlas";
            this.dateTimePickerVasarlas.Size = new System.Drawing.Size(135, 23);
            this.dateTimePickerVasarlas.TabIndex = 3;
            this.dateTimePickerVasarlas.ValueChanged += new System.EventHandler(this.dateTimePickerVasarlas_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(520, 411);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(679, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mennyiseg";
            // 
            // textBoxMennyiseg
            // 
            this.textBoxMennyiseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMennyiseg.Location = new System.Drawing.Point(693, 79);
            this.textBoxMennyiseg.Name = "textBoxMennyiseg";
            this.textBoxMennyiseg.Size = new System.Drawing.Size(42, 23);
            this.textBoxMennyiseg.TabIndex = 6;
            this.textBoxMennyiseg.TextChanged += new System.EventHandler(this.textBoxMennyiseg_TextChanged);
            this.textBoxMennyiseg.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMennyiseg_Validating);
            this.textBoxMennyiseg.Validated += new System.EventHandler(this.textBoxMennyiseg_Validated);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(693, 108);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(42, 46);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point(693, 160);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(42, 46);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tetel hozzadas";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nev";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 518);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Egysegar";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Egyseg";
            // 
            // comboBoxEgyseg
            // 
            this.comboBoxEgyseg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEgyseg.FormattingEnabled = true;
            this.comboBoxEgyseg.Location = new System.Drawing.Point(523, 484);
            this.comboBoxEgyseg.Name = "comboBoxEgyseg";
            this.comboBoxEgyseg.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEgyseg.TabIndex = 13;
            // 
            // buttonAddTetel
            // 
            this.buttonAddTetel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTetel.Location = new System.Drawing.Point(523, 514);
            this.buttonAddTetel.Name = "buttonAddTetel";
            this.buttonAddTetel.Size = new System.Drawing.Size(121, 23);
            this.buttonAddTetel.TabIndex = 14;
            this.buttonAddTetel.Text = "Hozzaadas";
            this.buttonAddTetel.UseVisualStyleBackColor = true;
            this.buttonAddTetel.Click += new System.EventHandler(this.buttonAddTetel_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxName.Location = new System.Drawing.Point(231, 484);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 15;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // textBoxEgysegar
            // 
            this.textBoxEgysegar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxEgysegar.Location = new System.Drawing.Point(231, 514);
            this.textBoxEgysegar.Name = "textBoxEgysegar";
            this.textBoxEgysegar.Size = new System.Drawing.Size(100, 23);
            this.textBoxEgysegar.TabIndex = 16;
            this.textBoxEgysegar.TextChanged += new System.EventHandler(this.textBoxEgysegar_TextChanged);
            this.textBoxEgysegar.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEgysegar_Validating);
            this.textBoxEgysegar.Validated += new System.EventHandler(this.textBoxEgysegar_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 550);
            this.Controls.Add(this.textBoxEgysegar);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonAddTetel);
            this.Controls.Add(this.comboBoxEgyseg);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMennyiseg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePickerVasarlas);
            this.Controls.Add(this.listBoxVasarlas);
            this.Controls.Add(this.textBoxTetel);
            this.Controls.Add(this.listBoxTetel);
            this.Name = "Form1";
            this.Text = "Vasarlas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tetelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tetelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxTetel;
        private TextBox textBoxTetel;
        private ListBox listBoxVasarlas;
        private DateTimePicker dateTimePickerVasarlas;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBoxMennyiseg;
        private Button buttonAdd;
        private Button buttonRemove;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxEgyseg;
        private Button buttonAddTetel;
        private TextBox textBoxName;
        private TextBox textBoxEgysegar;
        private ErrorProvider errorProvider1;
        private BindingSource tetelBindingSource;
        private BindingSource tetelBindingSource1;
    }
}