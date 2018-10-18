using KillerSudokuWindowsForms.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace KillerSudokuWindowsForms {
    public partial class MainForm : Form {

        private int dimension;
        private Funciones f;

        public MainForm() {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerateTable(int columnCount, int rowCount)
        {
            //Clear out the existing controls, we are generating a new table layout
            tableLayoutPanel1.Controls.Clear();

            //Clear out the existing row and column styles
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            //Now we will generate the table, setting up the row and column counts first
            tableLayoutPanel1.ColumnCount = columnCount;
            tableLayoutPanel1.RowCount = rowCount;



            for (int x = 0; x < columnCount; x++)
            {
                //First add a column
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

                for (int y = 0; y < rowCount; y++)
                {
                    //Next, add a row.  Only do this when once, when creating the first column
                    if (x == 0)
                    {
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    //Create the control, in this case we will add a button


                    BotonDobleTexto b = new BotonDobleTexto();
                    b.Height = 40;

                    tableLayoutPanel1.Controls.Add(b, x, y);


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)  //Generar
        { 
            f = new Funciones(trckTam.Value);
            f.CrearSudokusFinal();
            dimension = trckTam.Value;

            GenerateTable(trckTam.Value, trckTam.Value);

            ColorearTablero();
        }

        private List<Color> GenerarColores() {
            List<Color> colores = new List<Color>(); //Agregar colores
            colores.Add(Color.BlueViolet);
            colores.Add(Color.DarkGoldenrod);
            colores.Add(Color.Chartreuse);
            colores.Add(Color.Coral);
            colores.Add(Color.DeepPink); //5
            colores.Add(Color.DeepSkyBlue);
            colores.Add(Color.Red);
            colores.Add(Color.Blue);
            colores.Add(Color.Yellow);
            colores.Add(Color.PeachPuff); //10
            colores.Add(Color.Orange);
            colores.Add(Color.LimeGreen);
            colores.Add(Color.OrangeRed);
            colores.Add(Color.Green);
            colores.Add(Color.Sienna); //15
            colores.Add(Color.DarkSlateBlue);
            colores.Add(Color.Magenta);
            colores.Add(Color.Maroon);
            colores.Add(Color.Cyan);
            colores.Add(Color.Gold); //20
            return colores;
        }

        private void ColorearTablero()
        {


            List<Color> colores = GenerarColores();

            Figura[] listaFiguras = f.GetListaFiguras();

            int cont = 0;
            while (listaFiguras[cont] != null)
            {
                Ubicacion[] ubicaciones = listaFiguras[cont].GetLista();

                int x = ubicaciones[0].GetX();
                int y = ubicaciones[0].GetY();


                BotonDobleTexto botonActual = (BotonDobleTexto)tableLayoutPanel1.GetControlFromPosition(x, y);
                tableLayoutPanel1.Controls.Remove(botonActual);

                BotonDobleTexto botonNuevo = new BotonDobleTexto();

                if (listaFiguras[cont].GetTipo() != "solo")
                {
                    botonNuevo.LeftText = listaFiguras[cont].GetNumMeta().ToString() + listaFiguras[cont].GetOperacion();
                }

                botonNuevo.Height = 40;

                tableLayoutPanel1.Controls.Add(botonNuevo, x, y);

                foreach (Ubicacion ubicacion in ubicaciones)
                {
                    tableLayoutPanel1.GetControlFromPosition(ubicacion.GetX(), ubicacion.GetY()).BackColor = colores.ElementAt(cont % 15);
                }
                cont++;
            }
        }

        private void button3_Click(object sender, EventArgs e) //Cargar
        {
            openFileDialog1.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e) //Guardar
        {
            saveFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) //Una vez escogido archivo a abrir
        {
            using (System.IO.StreamReader readtext = new System.IO.StreamReader(openFileDialog1.FileName))
            {
                string linea = readtext.ReadLine();
                string size = "";
                int conta = 0;


                while (linea[conta] != ';')
                {
                    size += linea[conta];
                    conta++;
                }
                int dimensiones = Convert.ToInt32(size);
                dimension = dimensiones;

                f = new Funciones(dimensiones);
                f.Cargar(openFileDialog1.FileName);

                GenerateTable(dimensiones, dimensiones);

                ColorearTablero();



            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) //Una vez escogido archivo a guardar
        {
            f.Guardar(saveFileDialog1.FileName);
            MessageBox.Show("Guardado con éxito");
        }

        private void btnSolucionar_Click(object sender, EventArgs e) //Solucionar
        {

            //Iniciar temporizador
            Stopwatch watch = Stopwatch.StartNew();

            f.EjecutarAlgoritmoResolucion();

            int[,] solucion = f.GetSolucion();
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    tableLayoutPanel1.GetControlFromPosition(i, j).Text = solucion[i, j].ToString();
                }
            }

            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            lblBacktracking.Text = f.GetBackTracking().ToString();
            
            int minutos = Convert.ToInt32(elapsedMs / 60000);
            int segundos = Convert.ToInt32((elapsedMs / 1000) % 60);
            int milisegundos = Convert.ToInt32(elapsedMs % 1000);
            lblTiempo.Text = minutos.ToString() + "m "  + segundos.ToString() + "s "+ milisegundos.ToString() + "ms";
        }
    }
}
