using P1AFm.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AFm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido");

        }

        private int intentosRestantes = 3;
        private void button1Inicio_Click(object sender, EventArgs e)
        {/*
            labelTitulo.Text = "Bienvenido a mi App";
            Frmingreso forma = new Frmingreso();
            forma.Show();
            */



            string usuario = textBox1USR.Text.ToLower(); // Convertir a minúsculas
            string contrasena = textBox2Pass.Text.ToLower(); // Convertir a minúsculas
            

            if (usuario == "admin" && contrasena == "admin"){
                Frmingreso forma = new Frmingreso();
                MessageBox.Show("Bienvenido");
                forma.Show(); 
                textBox1USR.Clear();
                textBox2Pass.Clear();
                
            }
            else{

                if (intentosRestantes > 1){
                    intentosRestantes--;
                    MessageBox.Show($"Usuario o contraseña incorrecto. Te quedan {intentosRestantes} intentos.");
                    textBox1USR.Clear();
                    textBox2Pass.Clear();
                }
                else
                {
                    MessageBox.Show("Has agotado tus intentos. El botón se desactivará.");
                    button1Inicio.Enabled = false; // Desactivando el botón
                }
            }


            //    MessageBox.Show("Usuario o contraseña incorrecto");
            //    textBox1USR.Clear();
            //    textBox2Pass.Clear();
            //}






        }

        /* esto omitir
        private void buttonInicio_Click_1(object sender, EventArgs e)
        {
            labelTitulo.Text = "Bienvenido a mi App";
            Frmingreso forma = new Frmingreso();
            forma.Show();

        
        //se borro el buttonInicio 
        }
        */
        /*if (texBoxUsr.Text.Equals("admin")&&textBoxUsr.Text.Equals("admin"))
        {
        FrmIngreso forma = new FrmIngreso();
        forma.Show();
        else
        {
        MessageBox.Show("Usuario o contraseña incorrecto");
        }



        */
    }
}
