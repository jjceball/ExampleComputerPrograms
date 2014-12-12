import java.io.*;
import java.util.*;

public class KimIsAwesome
{
  public static void main(String[] args) throws java.io.IOException
  {
    String Kim1;
	
	BufferedReader br = new BufferedReader(new InputStreamReader(
							System.in)); 
		
	System.out.println("Is Kim Awesome?");
	
	System.out.println();
		
	Kim1 = br.readLine();
	
	System.out.println();
			
	if (Kim1.length() == 3)
	{
	  System.out.println("I know right? She pretty dope");	  
	  System.out.println();
	}
	else
	{
	  System.out.println("Ummmm you are wrong, she actually is!");
	  System.out.println();
	}
  }
}