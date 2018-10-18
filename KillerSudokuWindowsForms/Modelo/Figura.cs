using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerSudokuWindowsForms.Modelo
{
    public class Figura
    {
        int NumMeta { get; set; }
        String Operacion { get; set; }
        string Tipo { set; get; }
        Ubicacion[] ListaUbicacion { get; set; }
        int Acumulado { get; set; }
        int Ocupado { get; set; }



        public Figura(Ubicacion[] listaUbicaciones, string type)
        {
            NumMeta = 0;
            Operacion = "";
            Ocupado = 0;
            Acumulado = 0;
            Tipo = type;
            ListaUbicacion = listaUbicaciones;
        }

        public String GetTipo()
        {
            return Tipo;
        }
        public Ubicacion[] GetLista()
        {
            return ListaUbicacion;
        }
        public void SetNumMeta(int n)
        {
            NumMeta = n;
        }
        public void SetAcumulado(int n)
        {
            Acumulado = n;
        }
        public int GetNumMeta()
        {
            return NumMeta;
        }
        public void SetOperacion(String str)
        {
            Operacion = str;
        }
        public String GetOperacion()
        {
            return Operacion;
        }
        public int GetAcumulado()
        {
            return Acumulado;
        }
        public int GetOcupado()
        {
            return Ocupado;
        }
        public void AumentarOcupado(int num)
        {
            Ocupado = Ocupado + num;
        }
        public void DisminuirOcupado(int num)
        {
            Ocupado = Ocupado - num;
        }
        public void AumentarAcumuladoSum(int num)
        {
            Acumulado = Acumulado + num;
        }

        public void AumentarAcumuladoMul(int num)
        {
            Acumulado = Acumulado * num;
        }
        public void DisminuirAcumuladoSum(int num)
        {
            Acumulado = Acumulado - num;
        }
        public void DisminuirAcumuladoMul(int num)

        {
            Acumulado = Acumulado / num;

        }

    }
}
