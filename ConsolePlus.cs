//q8---------------------------
class ConsolePlus
{

  public  ConsolePlus ()
    {
        Console.WriteLine("DEAFAULT");         
    }

  public  ConsolePlus (string S):this()
    {
        Console.WriteLine(S);         
    }

 public  ConsolePlus (int a, int b)
    {
        Console.WriteLine(a+"+" +b +"="+(a+b));        
    }

 
   public  ConsolePlus (int a, int b, string S):this(a,b)
    {
            ConsolePlus cn=new ConsolePlus(S);

    }


}
   