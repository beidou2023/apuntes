using System.Windows;

namespace Examen2
{
    public partial class MainWindow : Window
    {
        string pass;
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            Password pass1 = new Password();
            MessageBox.Show(pass1.Nivel4("Nkw!o1rur"));
        }

        internal class Password
        {
            string password;

            public Password(string password)
            {
                this.password = password;
            }

            public Password()
            {

            }

            public bool VerificarPassword0(string cad)
            {
                if (cad.Length > 7)
                    return true;
                return false;
            }

            public string Nivel0(string cad)
            {
                if (VerificarPassword0(cad))
                    return "Contraseña de 8 char valido";
                return "Error: Contraseña de menos de 8 char";

            }

            public bool VerificarPassword1(string cad)
            {
                if (VerificarPassword0(cad))
                {
                    for (int i = 0; i < cad.Length; i++)
                    {
                        if (cad[i] == ' ')
                            return false;
                    }
                    return true;
                }
                return false;
            }

            public string Nivel1(string cad)
            {
                if (VerificarPassword1(cad))
                    return "Contraseña valida";
                return "Error: Contraseña incorrecta";
            }

            public bool VerificarPassword2(string cad)
            {
                int M = 0, m = 0;
                if (VerificarPassword1(cad))
                {
                    for (int i = 0; i < cad.Length; i++)
                    {
                        if (Char.IsUpper(cad[i]))
                            M++;
                        if (Char.IsLower(cad[i]))
                            m++;
                    }
                    if (M > 0 && m > 0)
                        return true;
                    else
                        return false;
                }
                return false;
            }

            public string Nivel2(string cad)
            {
                if (VerificarPassword2(cad))
                    return "Contraseña valida";
                return "Eror: Contraseña incorrecta";
            }

            public bool VerificarPassword3(string cad)
            {
                if (VerificarPassword2(cad))
                {
                    for (int i = 0; i < cad.Length; i++)
                    {
                        if (!Char.IsLetter(cad[i]) && !Char.IsNumber(cad[i]))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }

            public string Nivel3(string cad)
            {
                if (VerificarPassword3(cad))
                    return "Contraseña valida";
                return "Eror: Contraseña incorrecta";
            }

            public bool VerificarPassword4(string cad)
            {
                bool bandera = false;
                if (VerificarPassword3(cad))
                {
                    for (int i = 0; i < cad.Length; i++)
                    {
                        if (Char.IsNumber(cad[i]))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                return false;
            }

            public string Nivel4(string cad)
            {
                if (VerificarPassword4(cad))
                    return "Contraseña valida";
                return "Eror: Contraseña incorrecta";
            }
        }
    }



}
