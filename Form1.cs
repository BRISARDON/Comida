namespace Comida_2
{
    public partial class Form1 : Form
    {
        public int n;
        
        public Form1()
        {
            InitializeComponent();
        }

        public void tbHamburguesa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHamburguesaQueso_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDobleCarne_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPapasFritas_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPapasCheddar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCoca_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFanta_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSprite_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void vista(string nom, float cant, float precio)
        {
            //ADD NUEVO RENGLON
             n = dtgv.Rows.Add();
            //colocar info
            float total = precio * cant;

            dtgv.Rows[n].Cells[0].Value = nom;
            dtgv.Rows[n].Cells[1].Value = cant;
            dtgv.Rows[n].Cells[2].Value = precio;
            dtgv.Rows[n].Cells[3].Value = total;
            

        }
        
        private void btAgregarHamburguesa_Click(object sender, EventArgs e)
        {
           
            if (tbHamburguesa.Text != "")
            {
                
                Menu h2 = new Menu();
                float h = float.Parse(tbHamburguesa.Text);
                h2.HamburguesaSimple(h);
                tbHamburguesa.Text = "";

                vista("Hamburguesa", h, 500);
            }

            if (tbHamburguesaQueso.Text != "")
            {
                Menu h2 = new Menu();
                float h = float.Parse(tbHamburguesaQueso.Text);
                h2.HamburguesaQueso(h);
                tbHamburguesaQueso.Text = "";
                vista("Hamburguesa con Queso", h, 650);

            }

            if (tbDobleCarne.Text != "")
            {
                Menu h2 = new Menu();
                float h = float.Parse(tbDobleCarne.Text);
                h2.DobleCarne(h);
                tbDobleCarne.Text = "";

                vista("Doble Carne Doble Queso", h, 800);

            }


        }

        private void btAgregarPapas_Click(object sender, EventArgs e)
        {

            if(tbPapasFritas.Text != "")
            {
                Menu h2 = new Menu();
                float p = float.Parse(tbPapasFritas.Text);
                h2.PapasFritasSimple(p);
                tbPapasFritas.Text = "";
                vista("Papas Fritas", p, 300);
            }

            if (tbPapasCheddar.Text != "")
            {
                Menu h2 = new Menu();
                float p = float.Parse(tbPapasCheddar.Text);
                h2.PapasCheddar(p);
                tbPapasCheddar.Text = "";
                vista("Papas Cheddar", p, 450);
            }

        }

        private void btIngredientes_Click(object sender, EventArgs e)
        {
            // Agregar/quitar ingredientes -> lechuga, tomate, condimentos, etc
        }


        private void btImprimirTicket_Click(object sender, EventArgs e)
        {

            var ticket = new Ticket();
            ticket.Show();
            dtgv.Rows.Clear();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFecha1.Text = DateTime.Now.ToString();
        }

        private void btAgregarGaseosa_Click(object sender, EventArgs e)
        {
            if (tbCoca.Text != "")
            {
                Menu h2 = new Menu();
                float g = float.Parse(tbCoca.Text);
                h2.CocaCola(g);
                tbCoca.Text = "";
                vista("Coca Cola", g, 250);
            }

            if (tbFanta.Text != "")
            {
                Menu h2 = new Menu();
                float g = float.Parse(tbFanta.Text);
                h2.Fanta(g);
                tbFanta.Text = "";
                vista("Fanta", g, 250);
            }

            if (tbSprite.Text != "")
            {
                Menu h2 = new Menu();
                float g = float.Parse(tbSprite.Text);
                h2.Sprite(g);
                tbSprite.Text = "";
                vista("Sprite", g, 250);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            //this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             n = e.RowIndex;

            try {
                if (n != -1)
                {
                    string linea = (string)dtgv.Rows[n].Cells[0].Value;
                }
            }
            
            catch (Exception error){
                
                MessageBox.Show("error");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* if (File.Exists("Precio.txt"))
            {
                StreamReader archivoTotal = new StreamReader("Precio.txt", true);

                double suma = 0;

                string linea = archivoTotal.ReadLine();
                while (linea != null)
                {
                    double numero = double.Parse(linea);
                    suma = suma + numero;
                    linea = archivoTotal.ReadLine();
                }
                string lineaSuma = suma.ToString();
                labelTotal.Text = lineaSuma;
                archivoTotal.Close();
            
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (n != -1)
                {
                    dtgv.Rows.RemoveAt(n);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("error");
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}