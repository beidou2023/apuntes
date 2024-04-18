
package practicaex;

public class Licor extends Producto{
    private String tipoLicor;

    public Licor(String tipoLicor, String codProducto, String nombre, double precio, double cantidad) {
        super(codProducto, nombre, precio, cantidad);
        this.tipoLicor = tipoLicor;
    }

    public String getTipoLicor() {
        return tipoLicor;
    }

    public void setTipoLicor(String tipoLicor) {
        this.tipoLicor = tipoLicor;
    }
    
    
    @Override
    public double getCalcularDescuento(){
        if(getCantidad()>5)
            return getCalcularCosto()*0.05*-1;
        else
            return 0.0;
    }
    
    @Override
    public double getSubtotal()
    {
        return getCalcularCosto()+getCalcularDescuento();
    }
}
