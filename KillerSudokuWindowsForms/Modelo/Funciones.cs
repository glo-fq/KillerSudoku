using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KillerSudokuWindowsForms.Modelo
{
    public class Funciones
    {


        int N { set; get; } //este es el tam del tablero 

        int[,] Tablero { get; set; }
        int NumFigura { get; set; }
        int[,] FigurasArray { get; set; }
        Figura[] ListaFiguras { get; set; }
        int[,] Solucion { get; set; }
        int BackTracking { get; set; }


        public Funciones(int Num)
        {
            N = Num;
            ListaFiguras = new Figura[N * N];
            Tablero = new int[N, N];

            NumFigura = 1;
            FigurasArray = new int[N, N];
            Solucion = new int[N, N];
            BackTracking = 0;



        }
        public void SetN(int num)
        {
            N = num;
        }
        public void SetBackTracking(int num)
        {
            BackTracking += num;
        }
        public int GetBackTracking()
        {
            return BackTracking;
        }
        public Figura[] GetListaFiguras()
        {
            return ListaFiguras;
        }
        public int[,] GetSolucion()
        {
            return Solucion;
        }
        public Ubicacion NextEmpty(int[,] tab)
        {
            Ubicacion ubi;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (tab[i, j] == 0)
                    {
                        ubi = new Ubicacion(i, j);
                        return ubi;
                    }
                }
            }
            ubi = new Ubicacion(-1, -1);
            return ubi;

        }

        public char GenerarOperacion()
        {
            Random rnd = new Random();
            int aleatorio = rnd.Next(0, 2);
            if (aleatorio == 0)
                return '+';
            else
                return 'x';

        }

        public bool ComprobarEspacio(int[,] matrizFiguras, string figura, int orientacion, int pivoteX, int pivoteY)  //pivote es par de donde empieza la figura
        {

            int ubi1 = 0;
            int ubi2 = 0;
            int ubi3 = 0;
            int ubi4 = 0;


            if (figura == "cuadrado")
            {
                if (pivoteY + 1 < N && pivoteX + 1 < N)      //Que no se salga de los limites
                {
                    ubi1 = matrizFiguras[pivoteX, pivoteY];
                    ubi2 = matrizFiguras[pivoteX, pivoteY + 1];
                    ubi3 = matrizFiguras[pivoteX + 1, pivoteY];
                    ubi4 = matrizFiguras[pivoteX + 1, pivoteY + 1];

                    if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                    {
                        FigurasArray[pivoteX, pivoteY] = NumFigura;
                        FigurasArray[pivoteX, pivoteY + 1] = NumFigura;
                        FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                        FigurasArray[pivoteX + 1, pivoteY + 1] = NumFigura;

                        Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                        Ubicacion u2 = new Ubicacion(pivoteX, pivoteY + 1);
                        Ubicacion u3 = new Ubicacion(pivoteX + 1, pivoteY);
                        Ubicacion u4 = new Ubicacion(pivoteX + 1, pivoteY + 1);
                        Ubicacion[] list = new Ubicacion[4];
                        list[0] = u1;
                        list[1] = u2;
                        list[2] = u3;
                        list[3] = u4;
                        Figura fig = new Figura(list, "cuadrado");

                        SetListaFiguras(fig);

                        NumFigura++;
                        return true;
                    }
                    else
                        return false;

                }
                else
                    return false;
            }
            if (figura == "ele")
            {
                if (orientacion == 1 || orientacion == 2 || orientacion == 3 || orientacion == 4)
                {

                    if (orientacion == 1)
                    {
                        if (pivoteX + 2 < N && pivoteY + 1 < N)
                        {
                            ubi1 = matrizFiguras[pivoteX, pivoteY];
                            ubi2 = matrizFiguras[pivoteX + 1, pivoteY];
                            ubi3 = matrizFiguras[pivoteX + 2, pivoteY];
                            ubi4 = matrizFiguras[pivoteX + 2, pivoteY + 1];

                            if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                            {
                                FigurasArray[pivoteX, pivoteY] = NumFigura;
                                FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                                FigurasArray[pivoteX + 2, pivoteY] = NumFigura;
                                FigurasArray[pivoteX + 2, pivoteY + 1] = NumFigura;

                                Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                                Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                                Ubicacion u3 = new Ubicacion(pivoteX + 2, pivoteY);
                                Ubicacion u4 = new Ubicacion(pivoteX + 2, pivoteY + 1);
                                Ubicacion[] list = new Ubicacion[4];
                                list[0] = u1;
                                list[1] = u2;
                                list[2] = u3;
                                list[3] = u4;
                                Figura fig = new Figura(list, "ele");

                                SetListaFiguras(fig);

                                NumFigura++;
                                return true;
                            }
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                    if (orientacion == 2)
                    {
                        if (pivoteX + 2 < N && pivoteY - 1 > 0)
                        {
                            ubi1 = matrizFiguras[pivoteX, pivoteY];
                            ubi2 = matrizFiguras[pivoteX + 1, pivoteY];
                            ubi3 = matrizFiguras[pivoteX + 2, pivoteY];
                            ubi4 = matrizFiguras[pivoteX + 2, pivoteY - 1];

                            if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                            {
                                FigurasArray[pivoteX, pivoteY] = NumFigura;
                                FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                                FigurasArray[pivoteX + 2, pivoteY] = NumFigura;
                                FigurasArray[pivoteX + 2, pivoteY - 1] = NumFigura;

                                Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                                Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                                Ubicacion u3 = new Ubicacion(pivoteX + 2, pivoteY);
                                Ubicacion u4 = new Ubicacion(pivoteX + 2, pivoteY - 1);
                                Ubicacion[] list = new Ubicacion[4];
                                list[0] = u1;
                                list[1] = u2;
                                list[2] = u3;
                                list[3] = u4;
                                Figura fig = new Figura(list, "ele");

                                SetListaFiguras(fig);

                                NumFigura++;
                                return true;
                            }
                            else
                                return false;
                        }
                        else
                            return false;
                    }
                    if (orientacion == 3 || orientacion == 4)       //ver si en realidad mata dos pajaros de un tiro
                    {
                        if (pivoteX + 2 < N && pivoteY + 1 < N)
                        {
                            if (orientacion == 3)
                            {
                                ubi1 = matrizFiguras[pivoteX, pivoteY];
                                ubi2 = matrizFiguras[pivoteX, pivoteY + 1];
                                ubi3 = matrizFiguras[pivoteX + 1, pivoteY + 1];
                                ubi4 = matrizFiguras[pivoteX + 2, pivoteY + 1];

                                if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                                {
                                    FigurasArray[pivoteX, pivoteY] = NumFigura;
                                    FigurasArray[pivoteX, pivoteY + 1] = NumFigura;
                                    FigurasArray[pivoteX + 1, pivoteY + 1] = NumFigura;
                                    FigurasArray[pivoteX + 2, pivoteY + 1] = NumFigura;

                                    Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                                    Ubicacion u2 = new Ubicacion(pivoteX, pivoteY + 1);
                                    Ubicacion u3 = new Ubicacion(pivoteX + 1, pivoteY + 1);
                                    Ubicacion u4 = new Ubicacion(pivoteX + 2, pivoteY + 1);
                                    Ubicacion[] list = new Ubicacion[4];
                                    list[0] = u1;
                                    list[1] = u2;
                                    list[2] = u3;
                                    list[3] = u4;
                                    Figura fig = new Figura(list, "ele");

                                    SetListaFiguras(fig);

                                    NumFigura++;
                                    return true;
                                }
                                else
                                    return false;
                            }
                            if (orientacion == 4)
                            {
                                ubi1 = matrizFiguras[pivoteX, pivoteY];
                                ubi2 = matrizFiguras[pivoteX, pivoteY + 1];
                                ubi3 = matrizFiguras[pivoteX + 1, pivoteY];
                                ubi4 = matrizFiguras[pivoteX + 2, pivoteY];

                                if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                                {
                                    FigurasArray[pivoteX, pivoteY] = NumFigura;
                                    FigurasArray[pivoteX, pivoteY + 1] = NumFigura;
                                    FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                                    FigurasArray[pivoteX + 2, pivoteY] = NumFigura;

                                    Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                                    Ubicacion u2 = new Ubicacion(pivoteX, pivoteY + 1);
                                    Ubicacion u3 = new Ubicacion(pivoteX + 1, pivoteY);
                                    Ubicacion u4 = new Ubicacion(pivoteX + 2, pivoteY);
                                    Ubicacion[] list = new Ubicacion[4];
                                    list[0] = u1;
                                    list[1] = u2;
                                    list[2] = u3;
                                    list[3] = u4;
                                    Figura fig = new Figura(list, "ele");

                                    SetListaFiguras(fig);

                                    NumFigura++;
                                    return true;
                                }
                                else
                                    return false;
                            }

                        }
                        else
                            return false;
                    }
                }
                else
                    return false;

            }
            if (figura == "linea")
            {
                if (orientacion == 1) //vertical
                {
                    if (pivoteX + 3 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX + 1, pivoteY];
                        ubi3 = matrizFiguras[pivoteX + 2, pivoteY];
                        ubi4 = matrizFiguras[pivoteX + 3, pivoteY];

                        if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 2, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 3, pivoteY] = NumFigura;

                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                            Ubicacion u3 = new Ubicacion(pivoteX + 2, pivoteY);
                            Ubicacion u4 = new Ubicacion(pivoteX + 3, pivoteY);
                            Ubicacion[] list = new Ubicacion[4];
                            list[0] = u1;
                            list[1] = u2;
                            list[2] = u3;
                            list[3] = u4;
                            Figura fig = new Figura(list, "linea");

                            SetListaFiguras(fig);

                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                if (orientacion == 2)  //horizontal
                {
                    if (pivoteY + 3 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX, pivoteY + 1];
                        ubi3 = matrizFiguras[pivoteX, pivoteY + 2];
                        ubi4 = matrizFiguras[pivoteX, pivoteY + 3];

                        if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 1] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 2] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 3] = NumFigura;

                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX, pivoteY + 1);
                            Ubicacion u3 = new Ubicacion(pivoteX, pivoteY + 2);
                            Ubicacion u4 = new Ubicacion(pivoteX, pivoteY + 3);
                            Ubicacion[] list = new Ubicacion[4];
                            list[0] = u1;
                            list[1] = u2;
                            list[2] = u3;
                            list[3] = u4;
                            Figura fig = new Figura(list, "linea");

                            SetListaFiguras(fig);

                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
            if (figura == "te")
            {
                if (orientacion == 1)
                {
                    if (pivoteY - 1 >= 0 && pivoteY + 1 < N && pivoteX + 1 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX + 1, pivoteY];
                        ubi3 = matrizFiguras[pivoteX + 1, pivoteY - 1];
                        ubi4 = matrizFiguras[pivoteX + 1, pivoteY + 1];

                        if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY - 1] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY + 1] = NumFigura;

                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                            Ubicacion u3 = new Ubicacion(pivoteX + 1, pivoteY - 1);
                            Ubicacion u4 = new Ubicacion(pivoteX + 1, pivoteY + 1);
                            Ubicacion[] list = new Ubicacion[4];
                            list[0] = u1;
                            list[1] = u2;
                            list[2] = u3;
                            list[3] = u4;
                            Figura fig = new Figura(list, "te");

                            SetListaFiguras(fig);
                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                }
                if (orientacion == 2)
                {
                    if (pivoteY + 2 < N && pivoteX + 1 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX, pivoteY + 1];
                        ubi3 = matrizFiguras[pivoteX, pivoteY + 2];
                        ubi4 = matrizFiguras[pivoteX + 1, pivoteY + 1];

                        if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 1] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 2] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY + 1] = NumFigura;

                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX, pivoteY + 1);
                            Ubicacion u3 = new Ubicacion(pivoteX, pivoteY + 2);
                            Ubicacion u4 = new Ubicacion(pivoteX + 1, pivoteY + 1);
                            Ubicacion[] list = new Ubicacion[4];
                            list[0] = u1;
                            list[1] = u2;
                            list[2] = u3;
                            list[3] = u4;
                            Figura fig = new Figura(list, "te");
                            SetListaFiguras(fig);
                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                }
                else
                    return false;
            }
            if (figura == "snake")      //la figura que parece una serpiente
            {
                if (orientacion == 1)  //horizontal
                {
                    if (pivoteY - 1 >= 0 && pivoteY + 1 < N && pivoteX + 1 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX + 1, pivoteY];
                        ubi3 = matrizFiguras[pivoteX + 1, pivoteY - 1];
                        ubi4 = matrizFiguras[pivoteX, pivoteY + 1];

                        if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY - 1] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 1] = NumFigura;

                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                            Ubicacion u3 = new Ubicacion(pivoteX + 1, pivoteY - 1);
                            Ubicacion u4 = new Ubicacion(pivoteX, pivoteY + 1);
                            Ubicacion[] list = new Ubicacion[4];
                            list[0] = u1;
                            list[1] = u2;
                            list[2] = u3;
                            list[3] = u4;
                            Figura fig = new Figura(list, "snake");
                            int index = ListaFiguras.Length;
                            SetListaFiguras(fig);

                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                }
                if (orientacion == 2)  //vertical
                {
                    if (pivoteY + 1 < N && pivoteX + 2 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX + 1, pivoteY];
                        ubi3 = matrizFiguras[pivoteX + 1, pivoteY + 1];
                        ubi4 = matrizFiguras[pivoteX + 2, pivoteY + 1];

                        if ((ubi1 == 0) && (ubi2 == 0) && (ubi3 == 0) && (ubi4 == 0))   //Que no haya casillas ocupadas
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY + 1] = NumFigura;
                            FigurasArray[pivoteX + 2, pivoteY + 1] = NumFigura;

                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                            Ubicacion u3 = new Ubicacion(pivoteX + 1, pivoteY + 1);
                            Ubicacion u4 = new Ubicacion(pivoteX + 2, pivoteY + 1);
                            Ubicacion[] list = new Ubicacion[4];
                            list[0] = u1;
                            list[1] = u2;
                            list[2] = u3;
                            list[3] = u4;
                            Figura fig = new Figura(list, "snake");
                            int index = ListaFiguras.Length;
                            SetListaFiguras(fig);

                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                }

            }
            if (figura == "solo")
            {
                ubi1 = matrizFiguras[pivoteX, pivoteY];
                if (ubi1 == 0)
                {
                    FigurasArray[pivoteX, pivoteY] = NumFigura;
                    Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);

                    Ubicacion[] list = new Ubicacion[1];
                    list[0] = u1;

                    Figura fig = new Figura(list, "solo");
                    int index = ListaFiguras.Length;
                    SetListaFiguras(fig);
                    NumFigura++;
                    return true;
                }
                else
                    return false;
            }
            if (figura == "dos")
            {
                if (orientacion == 1)   //vertical
                {
                    if (pivoteX + 1 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX + 1, pivoteY];

                        if (ubi1 == 0 && ubi2 == 0)
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX + 1, pivoteY] = NumFigura;
                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX + 1, pivoteY);
                            Ubicacion[] list = new Ubicacion[2];
                            list[0] = u1;
                            list[1] = u2;
                            Figura fig = new Figura(list, "dos");
                            int index = ListaFiguras.Length;
                            SetListaFiguras(fig);
                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
                if (orientacion == 2)   //horizontal
                {
                    if (pivoteY + 1 < N)
                    {
                        ubi1 = matrizFiguras[pivoteX, pivoteY];
                        ubi2 = matrizFiguras[pivoteX, pivoteY + 1];

                        if (ubi1 == 0 && ubi2 == 0)
                        {
                            FigurasArray[pivoteX, pivoteY] = NumFigura;
                            FigurasArray[pivoteX, pivoteY + 1] = NumFigura;
                            Ubicacion u1 = new Ubicacion(pivoteX, pivoteY);
                            Ubicacion u2 = new Ubicacion(pivoteX, pivoteY + 1);
                            Ubicacion[] list = new Ubicacion[2];
                            list[0] = u1;
                            list[1] = u2;
                            Figura fig = new Figura(list, "dos");
                            int index = ListaFiguras.Length;
                            SetListaFiguras(fig);
                            NumFigura++;
                            return true;
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }


            return false;
        }

        public void ImprimirTableroFiguras()   //Este imprime el backtracking
        {
            string S = "";
            for (int i = 0; i < N; i++)
            {

                S = "";
                for (int j = 0; j < N; j++)
                {
                    string myStr = FigurasArray[i, j].ToString();
                    S += myStr + "       ";
                }
                Console.WriteLine(S);
            }
        }

        public void Print(int[,] arr)   //Funcion que imprime un array X
        {
            string S = "";
            for (int i = 0; i < N; i++)
            {

                S = "";
                for (int j = 0; j < N; j++)
                {
                    string myStr = arr[i, j].ToString();
                    S += myStr + "       ";
                }
                Console.WriteLine(S);
            }
        }

        public void GenerarFiguras()
        {
            Random rnd = new Random();
            string[] TipoFigura = new string[7] { "ele", "cuadrado", "linea", "snake", "solo", "te", "dos" };

            int ori = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (FigurasArray[i, j] == 0)
                    {
                        int fig = rnd.Next(0, 7);
                        if (fig == 0)
                            ori = rnd.Next(1, 5);
                        else
                            ori = rnd.Next(1, 3);

                        while (ComprobarEspacio(FigurasArray, TipoFigura[fig], ori, i, j) != true)
                        {
                            fig = rnd.Next(0, 7);
                            if (fig == 0)
                                ori = rnd.Next(1, 5);
                            else
                                ori = rnd.Next(1, 3);
                        }
                        //Print();
                        Console.WriteLine(" ");
                    }


                }
            }


        }
        public int ContarElementosLista()
        {
            int cont = 0;

            while (ListaFiguras[cont] != null)
            {
                cont++;
            }
            return cont;
        }

        public void ImprimirFig()
        {
            int cont = 0;
            String str = "";
            Console.WriteLine();

            while (ListaFiguras[cont] != null)
            {
                Figura f = ListaFiguras[cont];
                string tipoFigura = f.GetTipo();
                string meta = f.GetNumMeta().ToString();
                str += tipoFigura + "," + meta + f.GetOperacion() + ";" + System.Environment.NewLine;

                cont++;
            }
            Console.Out.WriteLine(str);
        }

        public void SetListaFiguras(Figura fig)
        {
            int cont = 0;
            bool bandera = false;
            while (bandera != true)
            {
                if (ListaFiguras[cont] == null)
                {
                    ListaFiguras[cont] = fig;
                    bandera = true;
                }
                else
                    cont++;
            }
        }
        public void SetLista(Figura[] lista, Figura fig)
        {
            int cont = 0;
            bool bandera = false;
            while (bandera != true)
            {
                if (lista[cont] == null)
                {
                    lista[cont] = fig;
                    bandera = true;
                }
                else
                    cont++;
            }
        }



        public bool VerificarFilasYColumnas(int[,] tablero, int num, int coordenadaX, int coordenadaY)
        {
            int[] fila = new int[N];
            int[] columna = new int[N];
            int contF = 0;
            int contCol = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((j == coordenadaY) || (i == coordenadaX))
                    {
                        if (j == coordenadaY)
                        {
                            fila[contF] = tablero[i, j];
                            contF++;
                        }
                        if (i == coordenadaX)
                        {
                            columna[contCol] = tablero[i, j];
                            contCol++;
                        }
                    }
                }
            }

            for (int k = 0; k < N; k++)
            {
                if (num == fila[k] || num == columna[k])
                    return false;
            }
            return true;
        }

        public Figura BuscarFigura(int x, int y)
        {
            Figura resul = null;
            int cont = 0;
            bool flag = false;
            while (ListaFiguras != null && flag == false)
            {
                Figura fig = ListaFiguras[cont];
                Ubicacion[] ubi = fig.GetLista();
                for (int i = 0; i < ubi.Length; i++)
                {
                    int ubiX = ubi[i].GetX();
                    int ubiY = ubi[i].GetY();
                    if (ubiX == x && ubiY == y)
                    {
                        resul = fig;
                        flag = true;
                        break;
                    }
                }
                cont++;
            }
            return resul;
        }
        public bool VerificarFigura(int[,] tablero, int num, int coordenadaX, int coordenadaY)
        {
            Figura fig = BuscarFigura(coordenadaX, coordenadaY);
            Ubicacion[] listaPosiciones = fig.GetLista();
            for (int i = 0; i < listaPosiciones.Length; i++)
            {
                Ubicacion ubi = listaPosiciones[i];
                int x = ubi.GetX();
                int y = ubi.GetY();
                int numTablero = tablero[x, y];
                if (num == numTablero)
                    return false;
            }
            return true;

        }
        public void ModificarFigura(int x, int y, int numero, int aumentarOquitar)    //1 = aumentar , 2 = quitar
        {

            int cont = 0;

            bool flag = false;
            while (ListaFiguras != null && flag == false)
            {
                Figura fig = ListaFiguras[cont];
                Ubicacion[] ubi = fig.GetLista();
                for (int i = 0; i < ubi.Length; i++)
                {
                    int ubiX = ubi[i].GetX();
                    int ubiY = ubi[i].GetY();
                    if (ubiX == x && ubiY == y)
                    {
                        if ((ListaFiguras[cont].GetOperacion() == "+") && aumentarOquitar == 1)
                        {
                            ListaFiguras[cont].AumentarAcumuladoSum(numero);
                            ListaFiguras[cont].AumentarOcupado(1);
                        }
                        if ((ListaFiguras[cont].GetOperacion() == "+") && aumentarOquitar == 2)
                        {
                            ListaFiguras[cont].DisminuirAcumuladoSum(numero);
                            ListaFiguras[cont].DisminuirOcupado(1);
                        }
                        if ((ListaFiguras[cont].GetOperacion() == "x") && aumentarOquitar == 1)
                        {
                            ListaFiguras[cont].AumentarAcumuladoMul(numero);
                            ListaFiguras[cont].AumentarOcupado(1);
                        }
                        if ((ListaFiguras[cont].GetOperacion() == "x") && aumentarOquitar == 2)
                        {
                            ListaFiguras[cont].DisminuirAcumuladoMul(numero);
                            ListaFiguras[cont].DisminuirOcupado(1);
                        }
                        flag = true;

                        break;
                    }
                }
                cont++;
            }



        }
        public bool VerificarOperacion(int[,] tablero, int num, int coordenadaX, int coordenadaY)
        {

            Figura fig = BuscarFigura(coordenadaX, coordenadaY);
            String operacion = fig.GetOperacion();
            int acumulado = fig.GetAcumulado();
            int meta = fig.GetNumMeta();

            if (operacion == "+")
            {
                if (fig.GetTipo() != "solo" && fig.GetTipo() != "dos")
                {
                    int totalSuma = acumulado + num;
                    if ((totalSuma <= meta) && (fig.GetOcupado() < 3))
                        return true;

                    if ((totalSuma == meta) && (fig.GetOcupado() == 3))
                        return true;
                    else
                        return false;
                }
                if (fig.GetTipo() == "dos")
                {
                    int totalSuma = acumulado + num;
                    if ((totalSuma <= meta) && (fig.GetOcupado() < 1))
                        return true;

                    if ((totalSuma == meta) && (fig.GetOcupado() == 1))
                        return true;
                    else
                        return false;
                }
                if (fig.GetTipo() == "solo")
                    return true;
            }
            if (operacion == "x")
            {
                if (fig.GetTipo() != "solo" && fig.GetTipo() != "dos")
                {
                    int totalMul = acumulado * num;
                    if ((totalMul <= meta) && (fig.GetOcupado() < 3))
                        return true;

                    if ((totalMul == meta) && (fig.GetOcupado() == 3))
                        return true;
                    else
                        return false;
                }
                if (fig.GetTipo() == "dos")
                {
                    int totalMul = acumulado * num;
                    if ((totalMul <= meta) && (fig.GetOcupado() < 1))
                        return true;

                    if ((totalMul == meta) && (fig.GetOcupado() == 1))
                        return true;
                    else
                        return false;
                }
                if (fig.GetTipo() == "solo")
                    return true;

            }
            if (operacion == "")
                return true;
            return false;
        }

        public int[,] GenerarSudoku()
        {
            int cont = 0;
            Random rnd = new Random();
            while (cont <= N)
            {

                int aleatorioX = rnd.Next(0, N);
                int aleatorioY = rnd.Next(0, N);
                int aleatorioNum = rnd.Next(1, N + 1);
                if (VerificarFilasYColumnas(Tablero, aleatorioNum, aleatorioX, aleatorioY) && VerificarFigura(Tablero, aleatorioNum, aleatorioX, aleatorioY))
                    Tablero[aleatorioX, aleatorioY] = aleatorioNum;
                cont++;
            }
            return Tablero;

        }
        public int[,] GenerarSudokuVacio()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Tablero[i, j] = 0;
                }
            }
            return Tablero;
        }


        public bool Resolver(int[,] tablero)
        {
            Ubicacion ubi = NextEmpty(tablero);
            if (ubi.GetX() == -1 && ubi.GetY() == -1)       //resuelto
                return true;

            int parX = ubi.GetX();
            int parY = ubi.GetY();

            for (int i = 1; i <= N; i++)
            {
                if (VerificarFilasYColumnas(tablero, i, parX, parY) && VerificarFigura(tablero, i, parX, parY))
                {
                    Tablero[parX, parY] = i;
                    //Console.WriteLine("-------------------------------------------------------------------------");
                    //Print(tablero);
                    if (Resolver(tablero))
                        return true;


                    //Console.WriteLine("**************************************************************************");
                    tablero[parX, parY] = 0;
                    //Print(tablero);
                    //Console.WriteLine("**************************************************************************");
                }
            }
            return false;
        }
        public bool ResolverDos(int[,] tablero)
        {
            Ubicacion ubi = NextEmpty(tablero);
            if (ubi.GetX() == -1 && ubi.GetY() == -1)       //resuelto
                return true;

            int parX = ubi.GetX();
            int parY = ubi.GetY();

            for (int i = 1; i <= N; i++)
            {
                if (VerificarFilasYColumnas(tablero, i, parX, parY) && VerificarFigura(tablero, i, parX, parY) && VerificarOperacion(tablero, i, parX, parY))
                {
                    Tablero[parX, parY] = i;
                    ModificarFigura(parX, parY, i, 1);

                    if (ResolverDos(tablero))
                        return true;



                    SetBackTracking(1);
                    tablero[parX, parY] = 0;
                    ModificarFigura(parX, parY, i, 2);

                }
            }
            return false;
        }


        public void EjecutarAlgoritmoInicial()
        {
            //TimeSpan stop;
            //TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("------------------------------------------------------------------------------------------");


            int[,] sudoku = GenerarSudoku();
            //Print(sudoku);
            //Console.WriteLine("  ");
            //Console.WriteLine("------------------------------------------------------------------------------------------");
            if (true == Resolver(sudoku))
            {
                //Print(sudoku);
                Solucion = sudoku;
            }
            else
                Console.WriteLine("Fail");

            //stop = new TimeSpan(DateTime.Now.Ticks);
            //Console.WriteLine();
            //Console.WriteLine(stop.Subtract(start).TotalMilliseconds);
        }
        public void EjecutarAlgoritmoResolucion()
        {
            //TimeSpan stop;
            //TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("------------------------------------------------------------------------------------------");


            int[,] sudoku = GenerarSudokuVacio();
            //Print(sudoku);
            //Console.WriteLine("  ");
            //Console.WriteLine("------------------------------------------------------------------------------------------");
            if (true == ResolverDos(sudoku))
            {
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" + Environment.NewLine);
                Print(sudoku);
                Solucion = sudoku;
                Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$" + Environment.NewLine);
                string bt = GetBackTracking().ToString();
                Console.WriteLine("BackTracking:" + bt + Environment.NewLine);
            }
            else
                Console.WriteLine("Fail");

            //stop = new TimeSpan(DateTime.Now.Ticks);
            //Console.WriteLine();
            //Console.WriteLine(stop.Subtract(start).TotalMilliseconds);
        }

        public void AsignarOperaciones()
        {
            int cont = 0;
            Random rand = new Random();
            while (ListaFiguras[cont] != null)
            {
                Figura fig = ListaFiguras[cont];
                Ubicacion[] ubicaciones = fig.GetLista();
                if (fig.GetTipo() == "solo")
                {
                    int x = ubicaciones[0].GetX();
                    int y = ubicaciones[0].GetY();
                    ListaFiguras[cont].SetNumMeta(Solucion[x, y]);

                }
                else
                {
                    if (fig.GetTipo() == "dos")
                    {
                        int x1 = Solucion[ubicaciones[0].GetX(), ubicaciones[0].GetY()];
                        int x2 = Solucion[ubicaciones[1].GetX(), ubicaciones[1].GetY()];
                        int numOp = rand.Next(1, 3);
                        if (numOp == 1)
                        {
                            ListaFiguras[cont].SetNumMeta(x1 + x2);
                            ListaFiguras[cont].SetOperacion("+");
                            ListaFiguras[cont].SetAcumulado(0);
                        }
                        if (numOp == 2)
                        {
                            ListaFiguras[cont].SetNumMeta(x1 * x2);
                            ListaFiguras[cont].SetOperacion("x");
                            ListaFiguras[cont].SetAcumulado(1);
                        }
                    }
                    else
                    {
                        int x1 = Solucion[ubicaciones[0].GetX(), ubicaciones[0].GetY()];
                        int x2 = Solucion[ubicaciones[1].GetX(), ubicaciones[1].GetY()];
                        int x3 = Solucion[ubicaciones[2].GetX(), ubicaciones[2].GetY()];
                        int x4 = Solucion[ubicaciones[3].GetX(), ubicaciones[3].GetY()];
                        int numOp = rand.Next(1, 3);
                        if (numOp == 1)
                        {
                            ListaFiguras[cont].SetNumMeta(x1 + x2 + x3 + x4);
                            ListaFiguras[cont].SetOperacion("+");
                            ListaFiguras[cont].SetAcumulado(0);
                        }
                        if (numOp == 2)
                        {
                            ListaFiguras[cont].SetNumMeta(x1 * x2 * x3 * x4);
                            ListaFiguras[cont].SetOperacion("x");
                            ListaFiguras[cont].SetAcumulado(1);
                        }
                    }

                }
                cont++;
            }
        }
        public void Guardar(string path)
        {
            string texto = "";
            int cont = 0;
            texto += N.ToString() + ";" + Environment.NewLine;
            int lim = ContarElementosLista();
            while (cont < lim - 1)
            {
                Figura fig = ListaFiguras[cont];
                Ubicacion[] ubicaciones = fig.GetLista();
                string num = fig.GetNumMeta().ToString();
                if (fig.GetTipo() == "solo")
                {
                    string ubiX = ubicaciones[0].GetX().ToString();
                    string ubiY = ubicaciones[0].GetY().ToString();
                    string par = "[" + ubiX + "," + ubiY + "]";
                    texto += fig.GetTipo() + ";" + par + ";" + num + ";" + fig.GetOperacion() + ";" + Environment.NewLine;
                }
                else
                {
                    if (fig.GetTipo() == "dos")
                    {
                        string ubi1 = "[" + ubicaciones[0].GetX().ToString() + "," + ubicaciones[0].GetY().ToString() + "]";
                        string ubi2 = "[" + ubicaciones[1].GetX().ToString() + "," + ubicaciones[1].GetY().ToString() + "]";

                        string par = ubi1 + "," + ubi2;
                        texto += fig.GetTipo() + ";" + par + ";" + num + ";" + fig.GetOperacion() + ";" + Environment.NewLine;
                    }
                    else
                    {
                        string ubi1 = "[" + ubicaciones[0].GetX().ToString() + "," + ubicaciones[0].GetY().ToString() + "]";
                        string ubi2 = "[" + ubicaciones[1].GetX().ToString() + "," + ubicaciones[1].GetY().ToString() + "]";
                        string ubi3 = "[" + ubicaciones[2].GetX().ToString() + "," + ubicaciones[2].GetY().ToString() + "]";
                        string ubi4 = "[" + ubicaciones[3].GetX().ToString() + "," + ubicaciones[3].GetY().ToString() + "]";
                        string par = ubi1 + "," + ubi2 + "," + ubi3 + "," + ubi4;
                        texto += fig.GetTipo() + ";" + par + ";" + num + ";" + fig.GetOperacion() + ";" + Environment.NewLine;
                    }
                }
                cont++;
            }
            if (cont < ContarElementosLista())
            {
                Figura fig = ListaFiguras[cont];
                Ubicacion[] ubicaciones = fig.GetLista();
                string num = fig.GetNumMeta().ToString();
                if (fig.GetTipo() == "solo")
                {
                    string ubiX = ubicaciones[0].GetX().ToString();
                    string ubiY = ubicaciones[0].GetY().ToString();
                    string par = "[" + ubiX + "," + ubiY + "]";
                    texto += fig.GetTipo() + ";" + par + ";" + num + ";" + fig.GetOperacion() + ";";
                }
                else
                {
                    if (fig.GetTipo() == "dos")
                    {
                        string ubi1 = "[" + ubicaciones[0].GetX().ToString() + "," + ubicaciones[0].GetY().ToString() + "]";
                        string ubi2 = "[" + ubicaciones[1].GetX().ToString() + "," + ubicaciones[1].GetY().ToString() + "]";

                        string par = ubi1 + "," + ubi2;
                        texto += fig.GetTipo() + ";" + par + ";" + num + ";" + fig.GetOperacion() + ";";
                    }
                    else
                    {
                        string ubi1 = "[" + ubicaciones[0].GetX().ToString() + "," + ubicaciones[0].GetY().ToString() + "]";
                        string ubi2 = "[" + ubicaciones[1].GetX().ToString() + "," + ubicaciones[1].GetY().ToString() + "]";
                        string ubi3 = "[" + ubicaciones[2].GetX().ToString() + "," + ubicaciones[2].GetY().ToString() + "]";
                        string ubi4 = "[" + ubicaciones[3].GetX().ToString() + "," + ubicaciones[3].GetY().ToString() + "]";
                        string par = ubi1 + "," + ubi2 + "," + ubi3 + "," + ubi4;
                        texto += fig.GetTipo() + ";" + par + ";" + num + ";" + fig.GetOperacion() + ";";
                    }
                }
            }
            string newPath = path;
            using (StreamWriter writetext = new StreamWriter(newPath + ".txt"))
            {
                writetext.WriteLine(texto);
            }
        }

        public void Cargar(string path)
        {
            Figura[] NewListaFiguras = new Figura[N * N];
            bool flag = true;
            using (StreamReader readtext = new StreamReader(path))
            {
                while (readtext.EndOfStream == false)
                {
                    if (flag == true)
                    {
                        string linea = readtext.ReadLine();
                        string size = "";
                        int conta = 0;


                        while (linea[conta] != ';')
                        {
                            size += linea[conta];
                            conta++;
                        }
                        int N = ConvertStringToInt(size);
                        SetN(N);
                        flag = false;
                    }
                    else
                    {
                        string linea = readtext.ReadLine();
                        string tipo = "";
                        int cont = 0;


                        while (linea[cont] != ';')
                        {
                            tipo += linea[cont];
                            cont++;
                        }
                        cont++;
                        if (tipo == "solo")
                        {
                            cont++;
                            string str = "";
                            while (linea[cont] != ',')
                            {
                                str += linea[cont].ToString();
                                cont++;
                            }
                            int x = ConvertStringToInt(str);
                            cont++;
                            str = "";
                            while (linea[cont] != ']')
                            {
                                str += linea[cont].ToString();
                                cont++;
                            }
                            int y = ConvertStringToInt(str);
                            cont += 2;
                            str = "";
                            while (linea[cont] != ';')
                            {
                                str += linea[cont].ToString();
                                cont++;
                            }
                            int meta = ConvertStringToInt(str);
                            Ubicacion ubi = new Ubicacion(x, y);
                            Ubicacion[] lisUbi = new Ubicacion[1];
                            lisUbi[0] = ubi;
                            Figura fig = new Figura(lisUbi, tipo);
                            fig.SetNumMeta(meta);


                            SetLista(NewListaFiguras, fig);

                        }
                        else
                        {
                            if (tipo == "dos")
                            {
                                cont++;
                                string str = "";
                                while (linea[cont] != ',')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int x1 = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ']')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int y1 = ConvertStringToInt(str);
                                cont += 3;
                                str = "";
                                while (linea[cont] != ',')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int x2 = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ']')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }

                                int y2 = ConvertStringToInt(str);
                                cont += 2;
                                str = "";
                                while (linea[cont] != ';')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int meta = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ';')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                string operacion = str;
                                Ubicacion ubi1 = new Ubicacion(x1, y1);
                                Ubicacion ubi2 = new Ubicacion(x2, y2);
                                Ubicacion[] lisUbi = new Ubicacion[2];
                                lisUbi[0] = ubi1;
                                lisUbi[1] = ubi2;
                                Figura fig = new Figura(lisUbi, tipo);
                                fig.SetNumMeta(meta);
                                fig.SetOperacion(operacion);
                                if (operacion == "+")
                                    fig.SetAcumulado(0);
                                else
                                    fig.SetAcumulado(1);
                                SetLista(NewListaFiguras, fig);
                            }
                            else
                            {
                                cont++;
                                string str = "";
                                while (linea[cont] != ',')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int x1 = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ']')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int y1 = ConvertStringToInt(str);
                                cont += 3;
                                str = "";
                                while (linea[cont] != ',')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int x2 = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ']')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }

                                int y2 = ConvertStringToInt(str);
                                cont += 3;
                                str = "";

                                while (linea[cont] != ',')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int x3 = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ']')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }

                                int y3 = ConvertStringToInt(str);
                                cont += 3;
                                str = "";

                                while (linea[cont] != ',')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int x4 = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ']')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }

                                int y4 = ConvertStringToInt(str);
                                cont += 2;
                                str = "";
                                while (linea[cont] != ';')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                int meta = ConvertStringToInt(str);
                                cont++;
                                str = "";
                                while (linea[cont] != ';')
                                {
                                    str += linea[cont].ToString();
                                    cont++;
                                }
                                string operacion = str;
                                Ubicacion ubi1 = new Ubicacion(x1, y1);
                                Ubicacion ubi2 = new Ubicacion(x2, y2);
                                Ubicacion ubi3 = new Ubicacion(x3, y3);
                                Ubicacion ubi4 = new Ubicacion(x4, y4);
                                Ubicacion[] lisUbi = new Ubicacion[4];
                                lisUbi[0] = ubi1;
                                lisUbi[1] = ubi2;
                                lisUbi[2] = ubi3;
                                lisUbi[3] = ubi4;
                                Figura fig = new Figura(lisUbi, tipo);
                                fig.SetNumMeta(meta);
                                fig.SetOperacion(operacion);
                                if (operacion == "+")
                                    fig.SetAcumulado(0);
                                else
                                    fig.SetAcumulado(1);
                                SetLista(NewListaFiguras, fig);
                            }
                        }
                    }
                }
            }
            ListaFiguras = NewListaFiguras;
        }
        public int ConvertStringToInt(string intString)
        {
            int i = 0;
            if (!Int32.TryParse(intString, out i))
            {
                i = -1;
            }
            return i;
        }


        public void CrearSudokusFinal()
        {
            GenerarFiguras();

            EjecutarAlgoritmoInicial();

            AsignarOperaciones();
        }

    }

}
