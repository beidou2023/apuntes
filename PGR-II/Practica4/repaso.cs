using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PGR_II_09_05_24
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        getnset test = new getnset();
        public MainWindow()
        {
            InitializeComponent();

            test.Nombre = "papas";
            test.Sexo = 'Z';
            test.Fechanacimiento = DateTime.Parse("25/05/24");
            test.Numerito1="42342";

            MessageBox.Show(test.infoe());
        }

        internal class getnset
        {
            #region atributos y propiedades
            private string nombre;
            private char sexo;

            private string numerito1;
            public string Numerito1
            {
                get
                {
                    if (numerito1.Length < 10)
                    {
                        string ceros = "";
                        int n = 10 - numerito1.Length;
                        for (int i = 0; i < n; i++)
                            ceros += "0";
                        return ceros + numerito1;
                    }
                    return numerito1;
                }
                set
                {
                    //esta llegando un valor aca, se asigno primero al numerito1
                    //
                    if (value.Length >= 4 && value.Length < 10)
                    {
                        bool band = true;
                        foreach (var carac in value)
                            if (!Char.IsDigit(carac))
                                band = false;

                        if (band)
                            numerito1 = value;
                        else
                            numerito1 = "1111";
                    }
                }
            }

            //propfull para crear un atributo privato con un public con
            //get&set

            private DateTime fechanacimiento;

            public DateTime Fechanacimiento
            {
                get { return fechanacimiento; }
                set { fechanacimiento = value; }
            }
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }
            public char Sexo
            {
                get { return sexo; }
                set { if (value == 'F' || value == 'M') { sexo = value; } else { sexo = 'F'; } }
            }

            #endregion

            public getnset() { }


            public string infoe()
            {
                return "Nombre: " + Nombre + " Sexo: " + Sexo + "" +
                    "\nFecha: " + Fechanacimiento.ToShortDateString() + " Codigo: "
                    + numerito1;
            }
        }


    }
}

