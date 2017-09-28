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
    public partial class FormRegCliente : Form
    {
        public FormRegCliente()
        {
            InitializeComponent();
        }
       
        private void pictureBox2_Click(object sender, EventArgs e)
        {
			FormMenu m = new FormMenu();
			m.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
			FormMenu m = new FormMenu();
			m.Show();
            this.Hide();
        }

      
       

        
        

   

       
    }
}
