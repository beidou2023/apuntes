using System.Windows;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        string Tnombre;
        double Tprecio;
        string detalles;
        int cont = 0,min=0,max=0; //contadores para almacenar indice de la lista
        List<Producto> productos = new List<Producto>(); //crear lista de objetos "Producto"
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btn_input_Click(object sender, RoutedEventArgs e)
        {
            lst_.Items.Clear();
            Tnombre=txb_nombre.Text;
            Tprecio=Convert.ToDouble(txb_precio.Text); //almacenar en las 2 variables para mayor facilidad
            Producto nuevoproducto=new Producto(); //instanciar objeto
            nuevoproducto.nombre= Tnombre;
            nuevoproducto.precio = Tprecio; //asignar atributos al obejto creado en este momento
            productos.Add(nuevoproducto); //agregar objeto a la lista
            if (cont == 0)
                lst_.Items.Add($"El producto {Tnombre} es el precio mayor {Tprecio}");
            else
            {
                if (Tprecio > productos[max].precio)
                    max = cont;    //guardar en max el indice
                else if (Tprecio < productos[min].precio)
                    min= cont;    //guardar en min el indice
                lst_.Items.Add($"El producto {productos[max].nombre} es el precio mayor " +
                    $"{productos[max].precio} y el producto {productos[min].nombre} es el menor" +
                    $"precio {productos[min].precio}"); //mostrar en lista, este sera dinamico
                                                        //es decir, cambiara cada vez q haga click
            }
            cont++;
            txb_nombre.Clear();
            txb_precio.Clear();
            txb_nombre.Focus();
        }

        void mostrar() 
        {
            lst_.Items.Clear();
            for (int i = 0; i < cont; i++)
            {
                lst_.Items.Add($"{productos[i].nombre} --> {productos[i].precio}"); //mostrar List en listbox
            }
        }
        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            mostrar();
        }
    }
}
