
package practicaex;

public class Lacteo extends Producto {
    private String tipoLacteo;

    public Lacteo(String tipoLacteo, String codProducto, String nombre, double precio, int cantidad) {
        super(codProducto, nombre, precio, cantidad);
        this.tipoLacteo = tipoLacteo;
    }

    public String getTipoLacteo() {
        return tipoLacteo;
    }

    public void setTipoLacteo(String tipoLacteo) {
        this.tipoLacteo = tipoLacteo;
    }
    
    @Override
    public double getCalcularDescuento(){
        
        return getCalcularCosto()*0.03*-1;
    }
   
    @Override
    public double getSubtotal()
    {
        return getCalcularCosto()+getCalcularDescuento();
    }
}
