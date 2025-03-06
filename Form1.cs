using Calculator_Scientific.Main;
using System.Windows.Forms;
using System;

namespace Calculator_Scientific
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string operacion = cmboperacion.SelectedItem.ToString();
            double valor1 = double.Parse(txtvalor1.Text);
            double valor2 = double.Parse(txtvalor2.Text);

            try
            {
                double resultado = Calculadora.Calcular(operacion.ToLower(), valor1, valor2);
                LblResultado.Text = $"resultado: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error: {ex.Message}");
            }
        }
    }
}
