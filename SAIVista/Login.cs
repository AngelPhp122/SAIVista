using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIVista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //**
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  TxtUser.MaxLength = 5;
            if ((String.IsNullOrEmpty(TxtUser.Text)) || (String.IsNullOrEmpty(TxtPass .Text)))
            {
                MessageBox.Show("Ingresa usuario y contraseña válido");
            }
            else
            {
                Form formularioMenu1 = new homeForm();
                formularioMenu1.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* try { 
            
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }  */
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //**
        }

        private void linkLabelRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {          
            MessageBox.Show("Ventana en mantenimiento");
            
            this.TxtUser.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          //ho

        }
    }
}
