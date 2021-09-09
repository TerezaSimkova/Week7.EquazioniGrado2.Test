using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Week7.EquazioniGrado2.Core;

namespace Week7.EquazioniGrado2.WinForm
{
    public partial class CalculatorFrom : Form
    {

        private double[] operation = new double[3];
        private Equation equazione = new Equation();

        public CalculatorFrom()
        {
            InitializeComponent();
        }
     
        private void uguale_Click(object sender, EventArgs e)
        {
            operation[0] = double.Parse(txtValue1.Text);

            operation[1] = double.Parse(txtValue2.Text);

            operation[2] = double.Parse(txtValue3.Text);

            var risultato = equazione.RisolviEquazioneDiSecondoGrado(operation[0], operation[1], operation[2]);

            if (risultato == null)
            {
                txtValue.Text = "Caso impossibile";
            }
            else if (risultato.Length == 1)
            {
                txtValue.Text = $"Soluzione unica:{risultato[0]}";
            }
            else if(risultato.Length == 2)
            {
                txtValue.Text = $"Soluzione distinte:{risultato[0]} e {risultato[1]}";
            }
        }



    }
}
