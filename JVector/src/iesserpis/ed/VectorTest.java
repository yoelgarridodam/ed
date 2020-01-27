package iesserpis.ed;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class VectorTest {

	@Test
	void max() {
		//fail("Not yet implemented");
		assertEquals (21, Vector.max((new int [] {14, 21, 12, 9, 7})));
	}
	
	@Test
	void selectionSort() {
		int[] v1 = {7, 9, 12, 14, 21};
		Vector.max(v1);
		assertArrayEquals(new int[] {7, 9, 12, 14, 21}, v1);
	}
	
}
