using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF___medici_pacienti
{
    public partial class FormPacient : Form
    {
        public Pacient mFormPacient;
        public FormPacient(Pacient f)
        {
            InitializeComponent();
            mFormPacient = f;

            button1.Text = "Adauga";
            if (f != null)
            {
                button1.Text = "Editeaza";
                textBoxNume.Text = f.NumePrenume;
                textBoxCNP.Text = f.Cnp;
                dateTimePickerDataNasterii.Value = f.DataNasterii;
                comboBoxCardSanatate.Text = f.CardSanatate.ToString();
                comboBoxOcupatie.Text = f.Ocupatie.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mFormPacient is null) mFormPacient = new Pacient();
            mFormPacient.NumePrenume = textBoxNume.Text;
            mFormPacient.DataNasterii = dateTimePickerDataNasterii.Value;
            mFormPacient.Cnp = textBoxCNP.Text;
            mFormPacient.CardSanatate = comboBoxCardSanatate.Text;
            mFormPacient.Ocupatie = comboBoxOcupatie.Text;
        }
    }
}
