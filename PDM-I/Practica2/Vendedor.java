
package practica2;

public class Vendedor extends Empleado{
    private int cantidadClientes;
    private double comision;

    public Vendedor(int cantidadClientes, double comision, String nombre, String apellido, int carnet, String codEmpleado, double pagoHora, double cantHoras, int fechaIngreso) {
        super(nombre, apellido, carnet, codEmpleado, pagoHora, cantHoras, fechaIngreso);
        this.cantidadClientes = cantidadClientes;
        this.comision = comision;
    }

    public double getComision() {
        return comision;
    }

    public void setComision(double comision) {
        this.comision = comision;
    }

    public int getCantidadClientes() {
        return cantidadClientes;
    }

    public void setCantidadClientes(int cantidadClientes) {
        this.cantidadClientes = cantidadClientes;
    }
    
    @Override
    public double calcularTotalSueldo(){
    
        return calcularSueldo()+comision;
    }
}
