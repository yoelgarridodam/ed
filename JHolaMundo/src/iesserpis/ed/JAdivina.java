package iesserpis.ed;

import java.util.Random;
import java.util.Scanner;

public class JAdivina {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		int a = (int)(Math.random()* 200);
		
		//se pide la variable a comparar
		System.out.println("Intenta adivinar el número");
		int b = teclado.nextInt();
		
		
		//se inicia el while para empezar el bucle de preguntas
		while (a != b) {
			
			if(a == b) {
		
		System.out.println("Correcto");
		
			}else if(b < a) {
				
				System.out.println("Es mayor");
			
			}else if (b > a){
			
				System.out.println("Es menor");
			}

			b = teclado.nextInt();
			
		}
		//Sale del bucle solo si acierta
		System.out.println("Correcto");

	}
}


