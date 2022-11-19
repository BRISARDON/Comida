using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comida_2
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
                
        private void lbHamburguesa_Click(object sender, EventArgs e)
        {
            

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            
            try
            {
                string archivo = File.ReadAllText("Archivo.txt");
                lbArticulos.Text = archivo;
                
                string precio = File.ReadAllText("Precio.txt");
                lbPrecio.Text = precio;
            }
            catch
            {
                MessageBox.Show("No selecciono ningun dato", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
           
            labelFecha2.Text = DateTime.Now.ToString();


    
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            File.Delete("Archivo.txt");
            File.Delete("Precio.txt");
            
            Close();
        }

        private void lbPrecio_Click(object sender, EventArgs e)
        {

        }
    }
}
