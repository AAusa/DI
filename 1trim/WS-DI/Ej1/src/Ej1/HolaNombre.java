package Ej1;

import java.util.Scanner;

public class HolaNombre {

	public static void main(String[] args) {
		String nombre;
		Scanner teclado = new Scanner(System.in);
		System.out.println("Introduzca tu nombre:");
		nombre = teclado.nextLine();
		System.out.println("Tu nombre es "+nombre);

	}

}
