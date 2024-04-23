using System.Windows;

namespace Ejercicio2Matrices
{
    public partial class MainWindow : Window
    {
        int filas = 0, columnas = 0,mitadFilas=0;
        int[,] matriz1, matriz2, matrizResultado; 
        Random numeroAleatorio = new Random();

        public MainWindow()
        {
            InitializeComponent();     
        }

        private void btn_calcular_Click(object sender, RoutedEventArgs e)
        {
            filas = Convert.ToInt32(txb_Nfilas.Text);
            columnas = Convert.ToInt32(txb_Mcolumnas.Text);
            matriz1 = new int[filas, columnas];
            matriz2 = new int[filas, columnas];
            matrizResultado = new int[filas, columnas];
            mitadFilas = filas / 2;

            matriz1 = GenerarAleatorios(matriz1,1,11);
            matriz2 = GenerarAleatorios(matriz2, 10, 21);
            matrizResultado = SumarMatrices(matriz1,matriz2,matrizResultado);
            MostrarMatrices();
        }

        public int[,] GenerarAleatorios(int[,]matriz,int inicio,int fin)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = numeroAleatorio.Next(inicio, fin);
                }
            }
            return matriz;
        }

        public int[,] SumarMatrices(int[,] matrizA, int[,] matrizB, int[,] matrizC)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matrizC[i, j] = matrizA[i, j]+ matrizB[i, j];
                }
            }
            return matrizC;
        }

        public void MostrarMatrices()
        {
            lbl_resultado.Content ="";
            lbl_matriz1.Content = "";
            lbl_matriz2.Content = "";
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {       
                    lbl_resultado.Content += matrizResultado[i,j]+"  ";
                    lbl_matriz1.Content += matriz1[i, j] + "  ";
                    if (matriz1[i, j] < 10) //Para crear espacio extra en caso de ser 1 digito
                        lbl_matriz1.Content += "  ";
                    lbl_matriz2.Content += matriz2[i, j] + "  ";
                }
                if (mitadFilas == i)
                {
                    lbl_matriz1.Content += "  +";
                    lbl_matriz2.Content += "  =";
                }
                lbl_resultado.Content+="\n\n";
                lbl_matriz1.Content += "\n\n";
                lbl_matriz2.Content += "\n\n";

            }
        }
    }
}
