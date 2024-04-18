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
using Microsoft.VisualBasic;
namespace ListasyObjetos
{
     
    public partial class MainWindow : Window
    {
        List<Jugador> jugadores= new List<Jugador>();
        public MainWindow()
        {
            InitializeComponent();
        }


        void buscarcamiseta()
        {

            foreach (Jugador jugador in jugadores)
            {
                if (txb_camiseta.Text == Convert.ToString(jugador.camiseta))
                {
                    MessageBox.Show("Camiseta ya repetida");
                    txb_camiseta.Focus();
                    return;
                }
            }
            Jugador nuevoJugador = new Jugador(txb_name.Text, Convert.ToInt32(txb_camiseta.Text), txb_pos.Text);
            jugadores.Add(nuevoJugador);
            lst_jugadores.Items.Add($"Jugador {nuevoJugador.nombre} --> {nuevoJugador.camiseta} --> {nuevoJugador.posicion}");
            txb_camiseta.Clear();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            buscarcamiseta();
        }

        private void btn_search_Click(object sender, RoutedEventArgs e)
        {
            lst_jugadores.Items.Clear();
            int cont = 0;
            string buscar=Interaction.InputBox("Ingrese la posicion a buscar");
            lst_jugadores.Items.Add("Posicion a buscar: "+buscar.ToUpper());

            for (int i = 0; i < jugadores.Count; i++)
            {
                if (buscar == jugadores[i].posicion)
                {
                    cont++;
                    lst_jugadores.Items.Add(jugadores[i].nombre);
                }
            }
            if(cont==0)
                lst_jugadores.Items.Add("No se encontraron jugadores en tal posicion");
        }
    }
}
