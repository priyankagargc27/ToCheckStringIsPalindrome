using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
     {
        //throw new NotImplementedException("Waiting to be implemented.");
        bool answer = true;
        int count = word.Length;
        char[] buffer;
        
        word = word.ToLower();
        buffer = word.ToCharArray();
        
        foreach(char c in buffer)
        {
            //Console.WriteLine("ch: " + c);
            //Console.WriteLine(buffer[0]);
        }
            int i=0;
            int len = count/2;
            char[] l = new char[len];
            char[] r = new char[len];
            
            // fill left buffer
            foreach(char c in buffer)
            {
                l[i] = c;
                
                Console.WriteLine("l: " + l[i]);
                
                i++;
                
                if(i == count/2)
                {
                   break; 
                }
            }
            
            Console.WriteLine();
            
            i = 0;
            // fill right buffer
            Array.Reverse(buffer);
            foreach(char c in buffer)
            {
                r[i] = c;
                
                Console.WriteLine("r: " + r[i]);
                
                i++;
                
                if(i == count/2)
                {
                   break; 
                }
            }
        
            i = 0;
            // now test left vs right
            foreach(char c in l)
            {
                if(c != r[i])
                {
                    answer = false;
                }
                
                i++;
            }
          
        
        return answer;
    }


    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("deleveled"));
        Console.WriteLine(Palindrome.IsPalindrome("Aryan"));

    }
}