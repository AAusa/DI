package Ej3;

import java.util.Scanner;

/*
 * %10 última cifra
 * (n/10)%10 Penultima
 * (n/100)%10 Antepenultima
 */
public class EsCapicua {	
	public static boolean esCapicua(int num) {
		String numero;
		String alReves = "";
		numero = num+"";
		
		if(numero.length() % 2 != 0) {
			for(int i = numero.length()-1; i >= 0; i--) {
				alReves += numero.charAt(i);
			}
			if(numero.compareTo(alReves) == 0) {
				return true;
			}
			else {
				return false;
			}
		}
		else {
			return false;
		}
		
	}
	
	public static void main(String[] args) {
		int numero;
		Scanner teclado = new Scanner(System.in);
		System.out.println("Introduzca un numero:");
		numero = teclado.nextInt();
		if(EsCapicua.esCapicua(numero)) {
			System.out.println("Es capicua");
		}
		else {
			System.out.println("NO es capicua");
		}
	}
}
