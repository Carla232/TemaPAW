
namespace WF___medici_pacienti
{
    partial class FormMedic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.comboBoxAn = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecializare = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nasterii";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "An Absolvire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Specializare";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(154, 58);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(194, 20);
            this.textBoxNume.TabIndex = 5;
            // 
            // dateTimePickerDataNasterii
            // 
            this.dateTimePickerDataNasterii.Location = new System.Drawing.Point(154, 113);
            this.dateTimePickerDataNasterii.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDataNasterii.Name = "dateTimePickerDataNasterii";
            this.dateTimePickerDataNasterii.Size = new System.Drawing.Size(194, 20);
            this.dateTimePickerDataNasterii.TabIndex = 6;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(154, 166);
            this.textBoxCNP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(194, 20);
            this.textBoxCNP.TabIndex = 7;
            // 
            // comboBoxAn
            // 
            this.comboBoxAn.FormattingEnabled = true;
            this.comboBoxAn.Items.AddRange(new object[] {
            "1950",
            "1960",
            "1970",
            "1980",
            "1990",
            "2000",
            "2010",
            "2020"});
            this.comboBoxAn.Location = new System.Drawing.Point(154, 210);
            this.comboBoxAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxAn.Name = "comboBoxAn";
            this.comboBoxAn.Size = new System.Drawing.Size(194, 21);
            this.comboBoxAn.TabIndex = 8;
            // 
            // comboBoxSpecializare
            // 
            this.comboBoxSpecializare.FormattingEnabled = true;
            this.comboBoxSpecializare.Items.AddRange(new object[] {
            "Cardiologie",
            "Neurologie",
            "Gastroenterologie"});
            this.comboBoxSpecializare.Location = new System.Drawing.Point(154, 258);
            this.comboBoxSpecializare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxSpecializare.Name = "comboBoxSpecializare";
            this.comboBoxSpecializare.Size = new System.Drawing.Size(194, 21);
            this.comboBoxSpecializare.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(154, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSpecializare);
            this.Controls.Add(this.comboBoxAn);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.dateTimePickerDataNasterii);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMedic";
            this.Text = "FormMedic";
            this.Load += new System.EventHandler(this.FormMedic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataNasterii;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.ComboBox comboBoxAn;
        private System.Windows.Forms.ComboBox comboBoxSpecializare;
        private System.Windows.Forms.Button button1;
    }
}