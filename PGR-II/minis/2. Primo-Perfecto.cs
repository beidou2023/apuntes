using System.Windows;

namespace Ejercicio
{
    public partial class MainWindow : Window
    {
        int n = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_verify_Click(object sender, RoutedEventArgs e)
        {
            Numero1 number = new Numero1();   
            n = Convert.ToInt32(txb_number.Text);
            MessageBox.Show($"La suma de los divisores de {n} es: {number.SumaDivisores(n)}");
            n = Convert.ToInt32(txb_number2.Text);
            MessageBox.Show($"El numero {n} {number.VerificarPrimo(n)}");
            n = Convert.ToInt32(txb_number3.Text);
            MessageBox.Show($"El numero {n} {number.VerificarPerfecto(n)}");
        }
    }

    internal class Numero1
    {
        public int n;
        private int cont = 0, sum = 0;

        public Numero1(int n)
        {
            this.n = n;
        }
        public Numero1()
        {

        }
        public int SumaDivisores(int n)
        {
            sum = 0;
            if (n < 0)
                return -1;
            else if (n <= 1)
                return n;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            return sum;
        }

        public string VerificarPrimo(int n)
        {
            int aux = SumaDivisores(n);
            if (aux == -1)
                return "No se admiten numeros negativos";
            else if (aux == n + 1)
                return "si es primo";
            else
                return "no es primo";
        }
        public string VerificarPerfecto(int n)
        {
            int aux = SumaDivisores(n);
            if (aux - n == n)
                return "es numero perfecto";
            else
                return "no es numero perfecto";
        }
    }
}
