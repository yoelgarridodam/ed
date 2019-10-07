package iesserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class JAdivina {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		int a = (int)(Math.random()* 50);
		
		
		System.out.println("Intenta adivinar el número");
		
		int b = teclado.nextInt();
		
		while (a != b) {
		
			if(a == b) {
		
		System.out.println("Correcto");
		
		}else if(b < a) {
				
				System.out.println("Es mayor");
		}
				else if (b > a){
					System.out.println("Es menor");
		}
				
				System.out.println("Inténtalo otra vez");
		
				b = teclado.nextInt();
		}

	}
}


