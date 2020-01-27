package iesserpis.ed;

public class Vector {

	public static void main(String[] args) {

		int[] v = new int[] {17, 12, 15, 9, 14};
		int x = 33;
		int index = indexOf(v, x);
		
		System.out.println("index = " + index);
		
		System.out.println("fin");
		
			
	}

	private static int indexOf(int[] v, int x) {

		for (int index = 0; index < v.length; index++)
			if (v[index] == x)
				return index;
		return -1; 
	}

	public static int max(int[] v) {
		int max=v[0];
		for(int i = 0; i <v.length; i++) {
			if(v[i]>max) {
				max=v[i];
			}
		}
		return max;
	}
}
