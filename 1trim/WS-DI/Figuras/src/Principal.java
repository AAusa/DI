import java.util.Scanner;

public class Principal {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		System.out.println("Introduce lado mayor para un rectángulo: ");
		double lM = teclado.nextDouble();
		System.out.println("Introduce lado menor para un rectángulo: ");
		double lm = teclado.nextDouble();
		Rectangulo r = new Rectangulo(lM, lm);
		
		System.out.println("Introduce radio mayor para una elipse: ");
		lM = teclado.nextDouble();
		System.out.println("Introduce radio menor para un rectángulo: ");
		lm = teclado.nextDouble();
		Elipse e = new Elipse (lM, lm); 
		
		System.out.println("Introduce lado  un cuadrado: ");
		lm = teclado.nextDouble();
		Cuadrado cu = new Cuadrado(lm);
		
		System.out.println("Introduce radio para un círculo: ");
		lm = teclado.nextDouble();
		Circulo ci = new Circulo(lm);
		
		Figura[] f = new Figura[4];
		f[0] = r;
		f[1] = e;
		f[2] = cu;
		f[3] = ci;
		
		/**
		 * Debemos crear un método en la clase figura, que tenga como
		 * parámetro de entrada un vector de figuras y nos devuelva la 
		 * figura con mayor área. El método se llamará mayorArea
		 */
		
		System.out.println("la figura de mayor es "+ Figura.mayorArea(f).toString());
		
	}

}