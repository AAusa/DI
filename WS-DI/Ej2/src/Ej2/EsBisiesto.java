package Ej2;

import java.util.Scanner;

public class EsBisiesto {

	public static void main(String[] args) {
		int numero;
		Scanner teclado = new Scanner(System.in);
		System.out.println("Introduzca un año:");
		numero = teclado.nextInt();
		if(numero % 4 == 0 && (numero % 100 != 0 || numero % 400 == 0)) {
			System.out.println("El año "+numero+" es bisiesto");
		}
		else {
			System.out.println("El año "+numero+" NO es bisiesto");
		}
		
	}

}
