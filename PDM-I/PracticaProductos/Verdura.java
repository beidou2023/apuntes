
package practicaex;

public class Verdura extends Producto{
    private String temporada;

    public Verdura(String temporada, String codProducto, String nombre, double precio, int cantidad) {
        super(codProducto, nombre, precio, cantidad);
        this.temporada = temporada;
    }

    public String getTemporada() {
        return temporada;
    }

    public void setTemporada(String temporada) {
        this.temporada = temporada;
    }
    
    
    @Override
    public double getCalcularSobreprecio()
    {
        if("invierno".equals(temporada.toLowerCase()))
            return getCalcularCosto()*0.05;
        else
            return 0.0;
    }
    
    
    @Override
    public double getSubtotal()
    {
        return getCalcularCosto()+getCalcularSobreprecio();
    }
}
