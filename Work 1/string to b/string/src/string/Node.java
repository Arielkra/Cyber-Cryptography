package string;
import java.util.*; 

class Node 
{ 

	 
	static void strToBinary(String s) 
	{ 
		int n = s.length(); 

		for (int i = 0; i < n; i++) 
		{ 
			
			int val = Integer.valueOf(s.charAt(i)); 

			
			String bin = ""; 
			while (val > 0) 
			{ 
				if (val % 2 == 1) 
				{ 
					bin += '1'; 
				} 
				else
					bin += '0'; 
				val /= 2; 
			} 
			bin = reverse(bin); 

			System.out.print(bin + " "); 
		} 
	} 

	static String reverse(String input) 
	{ 
		char[] a = input.toCharArray(); 
		int l, r = 0; 
		r = a.length - 1; 

		for (l = 0; l < r; l++, r--) 
		{ 
			
			char temp = a[l]; 
			a[l] = a[r]; 
			a[r] = temp; 
		} 
		return String.valueOf(a); 
	} 

	 
	public static void main(String[] args) 
	{ 
		Scanner console = new Scanner(System.in);
        System.out.print("Type your name : ");
        String name = console.nextLine();
        
        strToBinary(name);
         
	}

	
 
}


