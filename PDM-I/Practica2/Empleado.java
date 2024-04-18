
package practica2;
public class Empleado {
    private String nombre;
    private String apellido;
    private int carnet;
    private String codEmpleado;
    private double pagoHora;
    private double cantHoras;
    private int fechaIngreso;

    public Empleado(String nombre, String apellido, int carnet, String codEmpleado, double pagoHora, double cantHoras, int fechaIngreso) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.carnet = carnet;
        this.codEmpleado = codEmpleado;
        this.pagoHora = pagoHora;
        this.cantHoras = cantHoras;
        this.fechaIngreso = fechaIngreso;
    }

    public int getFechaIngreso() {
        return fechaIngreso;
    }

    public void setFechaIngreso(int fechaIngreso) {
        this.fechaIngreso = fechaIngreso;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getApellido() {
        return apellido;
    }

    public void setApellido(String apellido) {
        this.apellido = apellido;
    }

    public int getCarnet() {
        return carnet;
    }

    public void setCarnet(int carnet) {
        this.carnet = carnet;
    }

    public String getCodEmpleado() {
        return codEmpleado;
    }

    public void setCodEmpleado(String codEmpleado) {
        this.codEmpleado = codEmpleado;
    }

    public double getPagoHora() {
        return pagoHora;
    }

    public void setPagoHora(double pagoHora) {
        this.pagoHora = pagoHora;
    }

    public double getCantHoras() {
        return cantHoras;
    }

    public void setCantHoras(double cantHoras) {
        this.cantHoras = cantHoras;
    }
    

    public int calcularAntiguedad()
    {
        return 2024-fechaIngreso;
    }
    
    public double calcularExtra()
    {
        return 0;
    }
    
    public int calcularBonoAntiguedad(int ant)
    {
        if(ant>10)
            return 600;
        else if(ant>5)
            return 350;
        else
            return 0;
    }
    
    public double calcularSueldo()
    {
        return pagoHora*cantHoras+calcularBonoAntiguedad(calcularAntiguedad());
    }
    
    public double calcularSueldoSinAntiguedad()
    {
        return pagoHora*cantHoras;
    }
    
    public double calcularTotalSueldo(){
    
        return 0;
    }
}
