using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
			FormRegCliente Reg = new FormRegCliente();
			Reg.Show();
            this.Hide(); 

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
			FormInventarioMat Mat = new FormInventarioMat();
			Mat.Show();
            this.Hide();
        }
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
			FormFactura Fa = new FormFactura();
			Fa.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
			ForminventarioPren Pren = new ForminventarioPren();
			Pren.Show();
            this.Hide();
        }

    


       
    }
}
