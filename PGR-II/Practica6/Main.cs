using System.Windows;

namespace clases_06_03_24
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Cheff chefsito=new Cheff("66981CBBA","Lucas","Cruz","Chavez",DateTime.Parse("05/08/2018"), DateTime.Parse("05/08/1998"),2000,10,"Salsas");
            MessageBox.Show($"{chefsito.Nombres} gana {chefsito.CalcularSalario()}");
        }
    }

    #region Empleado
    class Empleado
    {
        #region atributos y propiedades
        private string ci;
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;
        private int salarioBase;
        private int horaExtra;

        public int HoraExtra
        {
            get { return horaExtra; }
            set { horaExtra = value; }
        }

        public int SalarioBase
        {
            get { return salarioBase; }
            set { salarioBase = value; }
        }
        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string SegundoApellido
        {
            get { return segundoApellido; }
            set { segundoApellido = value; }
        }
        public string PrimerApellido
        {
            get { return primerApellido; }
            set { primerApellido = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        #endregion

        #region Constructores

        public Empleado()
        {

        }

        public Empleado(string ci, string nombres, string primerApellido, string segundoApellido, DateTime fechaIngreso, DateTime fechaNacimiento, int salarioBase, int horaExtra)
        {
            this.ci = ci;
            this.nombres = nombres;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.fechaIngreso = fechaIngreso;
            this.fechaNacimiento = fechaNacimiento;
            this.salarioBase = salarioBase;
            this.horaExtra = horaExtra;
        }
        #endregion

        #region Metodos

        public virtual int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNacimiento.Year;
        }
        public virtual int CalcularAntiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }

        public virtual int CalcularSalario()
        {
            return SalarioBase;
        }
        #endregion
    }
    #endregion

    #region Ayudante
    class Ayudante : Empleado
    {
        #region atributos y propiedades
        private string carnetSanitario;
        public string CarnetSanitario
        {
            get { return carnetSanitario; }
            set { carnetSanitario = value; }
        }
        #endregion

        #region Constructores
        public Ayudante()
        {

        }

        public Ayudante(string ci, string nombres, string primerApellido, string segundoApellido, DateTime fechaIngreso, DateTime fechaNacimiento, int salarioBase, int horaExtra, string carnetSanitario) : base(ci, nombres, primerApellido, segundoApellido, fechaIngreso, fechaNacimiento, salarioBase, horaExtra)
        {
            CarnetSanitario = carnetSanitario;
        }
        #endregion

        #region Metodos
        public override int CalcularSalario()
        {
            return base.CalcularSalario() + HoraExtra * 25;
        }
        #endregion
    }
    #endregion

    #region Cheff

    class Cheff : Empleado
    {
        #region atributos y propiedades
        private string especialidad;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
        #endregion

        #region Constructores
        public Cheff()
        {

        }

        public Cheff(string ci, string nombres, string primerApellido, string segundoApellido, DateTime fechaIngreso, DateTime fechaNacimiento, int salarioBase, int horaExtra, string especialidad) : base(ci, nombres, primerApellido, segundoApellido, fechaIngreso, fechaNacimiento, salarioBase, horaExtra)
        {
            Especialidad = especialidad;
        }
        #endregion

        #region Metodos

        public override int CalcularSalario()
        {
            return base.CalcularSalario() + HoraExtra * 75;
        }
        #endregion
    }

    #endregion

}
