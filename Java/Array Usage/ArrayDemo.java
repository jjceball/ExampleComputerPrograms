/*
 * ArrayDemo.java
 */
 
public class ArrayDemo
{
	public static void main(String[] args)
	{
		int[] anArray;	// DECLARE an array of integers
		
		anArray = new int[10];  // CREATE an array of integers
		
		// Assign a value to each array element
		for (int i = 0; i < anArray.length; i++)
		{
			anArray[i] = i;
		}
		
		// Print a value from each array element
		for (int i = 0; i < anArray.length; i++)
		{
			System.out.print(anArray[i] + " " );
		}
		
		System.out.println();
	}
}