using System.Windows;
using Microsoft.VisualBasic;

namespace Examen2
{
    public partial class MainWindow : Window
    {
        List <Vehiculo> vehiculos=new List<Vehiculo>();
        int cont; //contador para autos dentro del rango
        string Tplaca;
        string Tmarca;
        double Tprecio,min, max,aux;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Vehiculo nuevoVehiculo=new Vehiculo();
            Tplaca=txb_marca.Text;
            Tmarca=txb_marca.Text;
            Tprecio = Convert.ToDouble(txb_precio.Text);
            nuevoVehiculo.placa = Tplaca;
            nuevoVehiculo.marca= Tmarca;
            nuevoVehiculo.precio = Tprecio;
            vehiculos.Add(nuevoVehiculo);
            lst_vehiculos.Items.Add($"Placa: {nuevoVehiculo.placa} --> Marca: {nuevoVehiculo.marca} --> Precio: {nuevoVehiculo.precio}");
            txb_marca.Clear();
            txb_precio.Clear();
            txb_placa.Clear();
            txb_placa.Focus();
        }

        private void btn_range_Click(object sender, RoutedEventArgs e)
        {
            min = 0; max = 0;cont = 0; aux=0 ;
            min = Convert.ToDouble(Interaction.InputBox("Ingrese el rango de precio minimo"));
            max = Convert.ToDouble(Interaction.InputBox("Ingrese el rango de precio maximo"));
            if (min > max)
            {
                aux = min;
                min = max;
                max = aux;
            }
            lst_vehiculos.Items.Clear();
            lst_vehiculos.Items.Add($"-*-*-*-*-Precio de vehiculos entre {min} y {max}-*-*-*-*-");

            for (int i = 0; i < vehiculos.Count; i++)
            {
                if (vehiculos[i].precio >= min && vehiculos[i].precio <= max)
                {
                    lst_vehiculos.Items.Add($"Placa: {vehiculos[i].placa} --> Marca: {vehiculos[i].marca} --> Precio: {vehiculos[i].precio}");
                    cont++;
                }
            }

            if(cont==0)
                lst_vehiculos.Items.Add($"Sin vehiculos en el rango ingresado");
        }
    }
}
