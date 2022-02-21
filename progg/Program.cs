using System;
namespace proogg
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1;
            Console.WriteLine("--       Birinchi raqamni kiriting:       --");
            num1 = Console.ReadLine();

            string num2;
            Console.WriteLine("--       Ikkinchi raqamni kiriting:       --");
            num2 = Console.ReadLine();

            double num11 = Convert.ToDouble(num1);
            double num22 = Convert.ToDouble(num2);

            string oper;
            Console.WriteLine("--       Operatorni kiriting:  ( P/s: + - / * )       --");
            oper = Console.ReadLine();


            if(oper !="+" && oper != "-" && oper != "/" && oper != "*"){
                Console.WriteLine("--       Bunday operator mavjud emas       --");
            }
            else if(oper == "+"){
                double resul = num11 + num22;
                Console.WriteLine(num11 + " + "+num22+" = "+ resul);
            }
            else if(oper == "-"){
                double resul = num11 - num22;
                Console.WriteLine(num11 + " - "+num22+" = "+ resul);
            }
            else if(oper == "*"){
                double resul = num11 * num22;
                Console.WriteLine(num11 + " * "+num22+" = "+ resul);
            }
            else if(oper == "/"){
                double resul = num11 / num22;
                Console.WriteLine(num11 + " / "+num22+" = "+ resul);
            }

            

       }
    }
}