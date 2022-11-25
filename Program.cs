namespace Patika2
{
    public class opertorler
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            a += 5;
            b *= 1;

            Console.WriteLine(a);
            Console.WriteLine(b);

            bool tr = true;
            bool fl = false;

            if(tr&&fl)
                Console.WriteLine("xxxxxxx");
            else if(tr&&!fl)
                Console.WriteLine("aaaaaa");

            bool ab = a > b;
            bool abc = a < b;

            Console.WriteLine(ab); 
            Console.WriteLine(abc);

            a++;
           int sonuc = a % 3;
            Console.WriteLine(sonuc);
        }
    }
}
