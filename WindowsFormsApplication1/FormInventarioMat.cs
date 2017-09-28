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
    public partial class FormInventarioMat : Form
    {
        public FormInventarioMat()
        {
            InitializeComponent();
        }
        FormMenu m = new FormMenu();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
          
            m.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            m.Show();
            this.Hide();
        }

       
       
    }
}
