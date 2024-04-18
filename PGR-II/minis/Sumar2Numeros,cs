using System.Windows;

namespace PGRII_16_04_2024
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int Sumar2Numeros(int a, int b)
        {
            return a+b;
        }
        private void btn_sumar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("La suma de los primeros 2 numeros es: " + Sumar2Numeros(1,2));
            MessageBox.Show("La suma de los primeros 3 numeros es: " + Sumar2Numeros(Sumar2Numeros(1, 2), 3));
            MessageBox.Show("La suma de los primeros 4 numeros es: " + Sumar2Numeros(Sumar2Numeros(1, 2), Sumar2Numeros(3, 4)));
            MessageBox.Show("La suma de los primeros 5 numeros es: " + Sumar2Numeros(Sumar2Numeros(1, 2), Sumar2Numeros(Sumar2Numeros(3, 4), 5)));
            MessageBox.Show("La suma de los primeros 6 numeros es: " + Sumar2Numeros(Sumar2Numeros(1, 2), Sumar2Numeros(Sumar2Numeros(3, 4), Sumar2Numeros(5, 6))));
        }
    }
}
