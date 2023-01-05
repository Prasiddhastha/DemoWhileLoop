using System;
namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //whileloop
            var i=0;
            while(i<10)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine("\n");
            //dowhileloop
            var j = 0;
            do
            {

                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }while(j<10);
        }
    }
}