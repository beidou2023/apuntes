
package practica2;

public class Contador extends Empleado {
    private double pagoHoraExtra;

    public Contador(double pagoHoraExtra, String nombre, String apellido, int carnet, String codEmpleado, double pagoHora, double cantHoras, int fechaIngreso) {
        super(nombre, apellido, carnet, codEmpleado, pagoHora, cantHoras, fechaIngreso);
        this.pagoHoraExtra = pagoHoraExtra;
    }

    public double getPagoHoraExtra() {
        return pagoHoraExtra;
    }

    public void setPagoHoraExtra(double pagoHoraExtra) {
        this.pagoHoraExtra = pagoHoraExtra;
    }
    
    
    public double calcularTotalSueldo(){
    
        return calcularSueldo()+getPagoHora()*pagoHoraExtra;
    }
}
