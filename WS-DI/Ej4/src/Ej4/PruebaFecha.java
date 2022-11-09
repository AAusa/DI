package Ej4;

public class PruebaFecha {
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Fecha f1 = Fecha.crearFecha();
		System.out.println("la fecha siguiente a " + f1.toString() + " es: "+ f1.diaSiguiente().toString());
		Fecha f2 = Fecha.crearFecha();
		if (f1.esAnterior(f2)) {
			System.out.println("la fecha " + f1.toString() + " es menor que " + f2.toString());
		}else {
			System.out.println("la fecha " + f1.toString() + " es mayor o igual que " + f2.toString());
		}
	}
}