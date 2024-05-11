using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1AFm.Formularios
{
    public partial class Frmingreso : Form
    {
        public Frmingreso()
        {
            InitializeComponent();
            this.comboBox1Facultades.DisplayMember = "Nombre";
        }


        public class Facultad
        {
            public string Nombre { get; set; }
            public Facultad(string nombre)
            {
                Nombre = nombre;
            }
        }

        // Crear instancias de Facultad
        Facultad ingenieria = new Facultad("Ingeniería");
        Facultad medicina = new Facultad("Medicina");
        Facultad derecho = new Facultad("Derecho");





        private void button1Sumar_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Agregar las instancias al ComboBox
                comboBox1Facultades.Items.Add(ingenieria);
                comboBox1Facultades.Items.Add(medicina);
                comboBox1Facultades.Items.Add(derecho);


                string textoNumero1 = textBox1Numero.Text;
                string textoNumero2 = textBox2Numero.Text;

                double numero1 = double.Parse(textoNumero1);
                double numero2 = double.Parse(textoNumero2);

                double resultado = numero1 + numero2;

                textBox3Resultado.Text = resultado.ToString();
                
            }

            catch (FormatException) {

                MessageBox.Show("Ingresa números válidos");
                textBox1Numero.Clear();
                textBox2Numero.Clear();
                textBox3Resultado.Clear();
            }
        }

        private void comboBox1Facultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el elemento seleccionado
            if (comboBox1Facultades.SelectedItem is Facultad facultadSeleccionada)
            {
                // Mostrar el nombre de la facultad
                MessageBox.Show(facultadSeleccionada.Nombre);
            }
        }

        private void button2Limpiar_Click(object sender, EventArgs e)
        {
            textBox1Numero.Clear();
            textBox2Numero.Clear();
            textBox3Resultado.Clear();
        }
    }
}
