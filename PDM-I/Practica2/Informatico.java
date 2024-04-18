
package practica2;

public class Informatico extends Empleado{
    private String especialidad;
    private String tipoTrabajo;
    //tipos: developer,encargado de calidad, manager

    public Informatico(String especialidad, String tipoTrabajo, String nombre, String apellido, int carnet, String codEmpleado, double pagoHora, double cantHoras, int fechaIngreso) {
        super(nombre, apellido, carnet, codEmpleado, pagoHora, cantHoras, fechaIngreso);
        this.especialidad = especialidad;
        this.tipoTrabajo = tipoTrabajo;
    }

    public String getTipoTrabajo() {
        return tipoTrabajo;
    }

    public void setTipoTrabajo(String tipoTrabajo) {
        this.tipoTrabajo = tipoTrabajo;
    }

    public String getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(String especialidad) {
        this.especialidad = especialidad;
    }
    
    public double calcularExtra(String especialidade)
    {
        if(especialidade=="developer")
            return 700;
        else if(especialidade=="encargado de calidad")
            return 400;
        else if(especialidade=="manager")
            return 1000;
        else
            return 0;          
    }  
    
    @Override 
    public double calcularTotalSueldo(){
        return calcularSueldo()+calcularExtra(especialidad);
    }
}
