using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void TxtbCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessTabKey(true);                 
            }            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtbNombre.Text != "" && txtbCorreo.Text != "")
            {
                MessageBox.Show("Te has registrado con éxito");
            }
            else
            {
                MessageBox.Show("Debes de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void TxtbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar== (char)Keys.Enter)
            {

            }
        }
    }
}
