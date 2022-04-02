
namespace WF___medici_pacienti
{
    partial class FormPacient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCardSanatate = new System.Windows.Forms.ComboBox();
            this.comboBoxOcupatie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(170, 125);
            this.dateTimePickerDataNasterii.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDataNasterii.TabIndex = 7;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(170, 52);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(194, 20);
            this.textBoxNume.TabIndex = 8;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(170, 194);
            this.textBoxCNP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(194, 20);
            this.textBoxCNP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Nasterii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNP";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(170, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 19);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Card Sanatate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ocupatie";
            // 
            // comboBoxCardSanatate
            // 
            this.comboBoxCardSanatate.FormattingEnabled = true;
            this.comboBoxCardSanatate.Items.AddRange(new object[] {
            "1950",
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.comboBoxCardSanatate.Location = new System.Drawing.Point(170, 262);
            this.comboBoxCardSanatate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCardSanatate.Name = "comboBoxCardSanatate";
            this.comboBoxCardSanatate.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCardSanatate.TabIndex = 18;
            // 
            // comboBoxOcupatie
            // 
            this.comboBoxOcupatie.FormattingEnabled = true;
            this.comboBoxOcupatie.Items.AddRange(new object[] {
            "1950",
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.comboBoxOcupatie.Location = new System.Drawing.Point(170, 332);
            this.comboBoxOcupatie.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxOcupatie.Name = "comboBoxOcupatie";
            this.comboBoxOcupatie.Size = new System.Drawing.Size(194, 21);
            this.comboBoxOcupatie.TabIndex = 19;
            // 
            // FormPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.comboBoxOcupatie);
            this.Controls.Add(this.comboBoxCardSanatate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.dateTimePickerDataNasterii);
            this.Name = "FormPacient";
            this.Text = "FormPacient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCardSanatate;
        private System.Windows.Forms.ComboBox comboBoxOcupatie;
    }
}