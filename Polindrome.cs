Using System;

pulic class Polindrome
{  
    static void Main(string[] args)
    {  
        int num, rem, sum = 0, temp;   
        Console.Write("\n Enter a number: ");  
        num = Convert.ToInt32(Console.ReadLine());  
        temp = num;  
        while (num > 0) {  
            rem = num % 10;    
            num = num / 10;    
            sum = sum * 10 + rem;  
        }  
        Console.WriteLine("The Reversed Number is: {0}", sum);  
        if (temp == sum)   
        {  
            Console.WriteLine("Number is Palindrome");  
        } else {  
            Console.WriteLine("Number is not a palindrome");  
        }  
        Console.ReadLine();  
    }  
}  
