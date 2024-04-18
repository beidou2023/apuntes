
package practica2;

public class Practica2 {
    public static double sueldos=0;
    public static void main(String[] args) {
        Contador cont1=new Contador(10, "Luis", "Fernandez", 1323, "LUFE567", 35, 8, 2000);
        Informatico inf1=new Informatico("manager","Presencial","Alberto", "Perez", 6133, "ALPE789", 50, 5, 2000);
        Vendedor vend1=new Vendedor(10, 200, "Raul", "Ramirez", 389, "RARA123", 2533, 6, 2008);

        sueldos=cont1.calcularTotalSueldo()+inf1.calcularTotalSueldo()+vend1.calcularTotalSueldo();
        System.out.println("-----------------------------------------------------------------------");
        
        System.out.println("Nombre //   Apellido // Cargo // Codigo Empleado // Sueldo Total");

        Imprimir(cont1.getNombre(),cont1.getApellido(),"CONTADOR",cont1.getCodEmpleado(),cont1.calcularTotalSueldo());
        Imprimir(inf1.getNombre(),inf1.getApellido(),"INFORMATICO",inf1.getCodEmpleado(),inf1.calcularTotalSueldo());
        Imprimir(vend1.getNombre(),vend1.getApellido(),"VENDEDOR",vend1.getCodEmpleado(),vend1.calcularTotalSueldo());

        System.out.println("--------------------------------------TOTAL A PAGAR: "+sueldos+" Bs.");
          
    }
    
    
    public static void Imprimir(String nombre,String Apellido,String cargo,String cod ,double total)
    {
        System.out.println(nombre+"-->"+Apellido+"---->"+cargo+"----->"+cod+"------------->"+total+" Bs.");
    }
    
}
