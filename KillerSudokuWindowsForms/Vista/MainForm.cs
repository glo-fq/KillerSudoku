using PruebasSudoku;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KillerSudokuWindowsForms {
    public partial class MainForm : Form {

        private int dimension;
        private Funciones f;

        public MainForm() {
            InitializeComponent();
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

        private void btnGenerar_Click(object sender, EventArgs e) { //Generar
            f = new Funciones(trckTam.Value);
            dimension = trckTam.Value;
        }

        private List<Color> GenerarColores() {
            List<Color> listaColores = new List<Color>();
            //Codigo faltante
            return listaColores;
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

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) //Una vez escogido archivo a guardar
        {

        }

        private void btnSolucionar_Click(object sender, EventArgs e) //Solucionar
        {

        }
    }
}
