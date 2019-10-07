package iesserpis.ed;

import java.util.Scanner;

public class HolaMundo {

	public static void main(String[] args) {
		
		Scanner teclado = new Scanner(System.in);
		
		System.out.print("Introduce tu nombre: ");
		String nombre = teclado.nextLine();
	
		System.out.print("Introduce tu edad: ");
		int edad = teclado.nextInt();
		
		System.out.println("Hola " + nombre + ". El año que viene tendrás " + (edad + 1));
	}

}
	