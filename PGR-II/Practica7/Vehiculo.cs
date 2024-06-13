using System.Windows;

namespace clase_06_11_24_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Vehiculo v1 = new Vehiculo(2000, "433ADD");

            if (v1.ValidacionPlaca())
                MessageBox.Show("Placa ok");
            else
                MessageBox.Show("Placa no-ok");
        }
    }

    namespace clase_06_11_24_1
    {
        internal class Vehiculo : IVehiculo
        {
            private int fabricationYear;
            private string placa;

            public Vehiculo(int fabricationYear, string placa)
            {
                this.fabricationYear = fabricationYear;
                this.placa = placa;
            }

            public int Antiguedad()
            {
                return DateTime.Now.Year - fabricationYear;
            }

            public bool ValidacionPlaca()
            {
                if (placa.Length == 6 || placa.Length == 7)
                {
                    for (int i = placa.Length - 3; i < placa.Length; i++)
                    {
                        if (!Char.IsLetter(placa[i]))
                            return false;
                    }
                    for (int i = 0; i < placa.Length - 4; i++)
                    {
                        if (!Char.IsDigit(placa[i]))
                            return false;
                    }
                    return true;
                }
                return false;
            }
        }
    }

    namespace clase_06_11_24_1
    {
        internal interface IVehiculo
        {
            int Antiguedad();
            bool ValidacionPlaca();
        }
    }
}

