/*See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");*/

//تمرین 6
#region 

/*namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(1, 2));
            Console.WriteLine(test(3, 2));
            Console.WriteLine(test(2, 3));
            Console.ReadLine();

        }
        public static int test(int x, int y)
        {
            return x == y ? (x + y)*3 : x + y;
      
        }
    }

}*/
#endregion

//تمرین4
#region
/*for (char i = 'z'; i >= 'a'; i--)
{
    Console.WriteLine(i);
}*/
#endregion



//تمرین14
#region


/*namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

        }
        public void printhellobeforname(String Name) { 
        
            Console.WriteLine("hello"+Name);    
        

        
        

        }
    }

}*/
#endregion

//تمرین 15
#region
/*namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Program Program = new Program();
            Program.printhellobeforname();

        }
        public void printhellobeforname(String Name) { 
            Console.WriteLine("hello" + Name);

        }
    }

}*/
#endregion


//تمرین3
#region
/*using System;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number : ");
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 1)
                Console.WriteLine("Entered number is odd.");
            else
                Console.WriteLine("Entered number is even.");
            Console.ReadKey(true);
        }
    }
}*/
#endregion

//تمرین 7
#region
/*using System;

namespace Camelcase
{
    class Camelcase
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Result : " + sum);
            Console.ReadLine();

        }
    }
}*/

#endregion


//تمریت10
#region
/*int a, b, s, d, m, z;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
s = a + b;
m = a - b;
z = a * b;
d = a / b;
Console.WriteLine("jame:" + s);
Console.WriteLine("menha:" + m);
Console.WriteLine("zarb:" + z);
Console.WriteLine("taghsim:" + d);
Console.ReadKey();*/

#endregion
