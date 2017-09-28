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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu m = new FormMenu();
            m.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(56, 59);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Size = new Size(52, 50);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = textBox1.Text;
                string contraseña = textBox2.Text;
                if (radioButton1.Checked == true && radioButton2.Checked == false && usuario == "Elsa sanabria" && contraseña == "1234")
                {
                    FormMenu m = new FormMenu();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    if (radioButton2.Checked == true && radioButton1.Checked == false && usuario == "secret" && contraseña == "5678")
                    {
                        FormMenu m = new FormMenu();
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error controlado", MessageBoxButtons.OK);
            }
        }
    }
}




