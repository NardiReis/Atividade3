using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        Double dbAltura, dbPeso, dbImc;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Double.TryParse(txtPeso.Text, out dbPeso);
            Double.TryParse(txtAltura.Text, out dbAltura);
            dbImc = dbPeso / (Math.Pow(dbAltura, 2));
            dbImc = Math.Round(dbImc, 1);
            txtIMC.Text = dbImc.ToString();

            if (dbImc < 18.5)
                txtClassificacao.Text = "Magreza";
            else if (dbImc < 25)
                txtClassificacao.Text = "Normal";
            else if (dbImc < 30)
                txtClassificacao.Text = "Sobrepeso";
            else if (dbImc < 40)
                txtClassificacao.Text = "Obesidade";
            else
                txtClassificacao.Text = "Obesidade Grave";
        }

        private void TxtAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtPeso_Validated(object sender, EventArgs e)
        {

        }
    }
}
