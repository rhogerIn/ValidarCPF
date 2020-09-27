using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ValidarCpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidarCpf_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCpf.ValCpf(txtCpf.Text))
                {

                    MessageBox.Show("Este CPF é válido!");
                }
                else
                {
                    MessageBox.Show("CPF INVALIDO");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Você digitou menos de 11 caracteres!");
            }
            
        }
    }
}
