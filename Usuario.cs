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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Si esta activo recordar
            if(chkRecordar.Checked)
            {
                //las guardo en las variables del sistema
                Properties.Settings.Default.Usuario = txtUsuario.Text;
                Properties.Settings.Default.Contraseña = txtContraseña.Text;
                Properties.Settings.Default.Recordar= chkRecordar.Checked;
                Properties.Settings.Default.Save(); //guardar
                Properties.Settings.Default.Reload(); //actualizar

                MessageBox.Show("Datos guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                Properties.Settings.Default.Usuario = "";
                Properties.Settings.Default.Contraseña = "";
                Properties.Settings.Default.Recordar = false;
                Properties.Settings.Default.Save(); 
                Properties.Settings.Default.Reload(); 

                MessageBox.Show("Datos no guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            //this.Close();

            var principal = new Form1();
            principal.Show();


            
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            //Si la variable recordar es V
            if (Properties.Settings.Default.Recordar == true)
            {
                txtUsuario.Text = Properties.Settings.Default.Usuario;
                txtContraseña.Text = Properties.Settings.Default.Contraseña;
                chkRecordar.Checked = Properties.Settings.Default.Recordar;

            }
            //Si no se guardan, se borran
            else
            {
                txtUsuario.Text = "";
                txtContraseña.Text = "";
                chkRecordar.Checked = false;

            }


        }
    }
}
