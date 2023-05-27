namespace ConsoleAppCShapSE1740.Programming;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 10, b = 20, c = 30;

        Num num = new Num();
        num.Num01 = a;
        num.Num02 = b;

        Console.WriteLine(num.Add());

        Console.ReadLine();
    }

    public static int Add(int x, int y) => x + y;
    //overloading (nap chong/qua tai)
    public static double Add(double x, double y) => x + y;
    public static double Add(int x, int y, double z) => Add(Add(x,y), z);

    /*
     Required:
        - Sum of serials (even/odd): 1+2+3+..+n?:
            + loop
            + recursion?
     */
    //loop
    public static long Sum(int n)
    {
        long total = 0;
        int i = 1;
        //do..while, for, forEach
        while (i <= n)
        {
            if (i % 2 == 0) total += i;//total = total + i; -=, *=, /=, %=...
            i++; //i=i+1; unary
        }

        return total;
    }
  
    public static long Total(int n)
    {
        if (n == 0 || n == 1) return n;
        return n + Total(n-1);
    }

}