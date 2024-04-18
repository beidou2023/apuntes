package practicaex;

public class PracticaEx {

    private static double monto=0.0;
    public static void main(String[] args) {
        Lacteo l1 = new Lacteo("queso","ABC123","LEE",6,30);
        monto+=l1.getSubtotal();
        Verdura v1=new Verdura("invierno","ABC123","LEE",20,6);
        monto+=v1.getSubtotal();
        Licor lic=new Licor("vino","ABC123","LEE",200,5);
        monto+=lic.getSubtotal();
        
        System.out.println("-*-*-*-*-*-*-*-*-*-*-*-*- Factura -*-*-*-*-*-*-*-*-*-*-*-*-");
        System.out.println("Detalle | Cantidad | P.Unitario  | Desc/cargo | Subtotal");
        generardetalles(l1.getTipoLacteo(),l1.getCantidad(),l1.getPrecio(),l1.getCalcularDescuento(),l1.getSubtotal());
        generardetalles(v1.getNombre(),v1.getCantidad(),v1.getPrecio(),v1.getCalcularSobreprecio(),v1.getSubtotal());
        generardetalles(lic.getTipoLicor(),lic.getCantidad(),lic.getPrecio(),lic.getCalcularDescuento(),lic.getSubtotal());
        System.out.println("-------------------------------------------------------------");
        System.out.println("SUBTOTAL:                                             "+String.format("%.1f", monto));
        System.out.println("DESCUENTO:                                             "+descuento(monto));
        System.out.println("PRECIO TOTAL:                                         "+calcularTotal(monto));
        System.out.println("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
    }
    
    public static double calcularTotal(double monto)
    {
        if(monto>1000)
            return monto-20;
        else if(monto>200)
            return monto-12;
        else if(monto>100)
            return monto-5;
        else
            return monto;
    }
    
    public static double descuento(double monto){
         if(monto>1000)
            return -20;
        else if(monto>200)
            return -12;
        else if(monto>100)
            return -5;
        else
            return 0;
    }
    
    public static void generardetalles(String nombre,double cantidad,double precio,double descuento,double subtotal)
    {
        System.out.println("*"+nombre);
        System.out.println("              "+cantidad+"      X  "+precio
                +"          "+String.format("%.1f", descuento)
                +"         "+String.format("%.1f", subtotal));
    }
}
