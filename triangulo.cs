using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ7
{
    public class triangulo
    {
        private int num1 { get; set; }
        private int num2 { get; set; }
        private int num3 { get; set; }

        public triangulo()
        {
            this.num1 = 5;
            this.num2 = 50;
            this.num3 = 5;

        }

        public void proceso()
        {
            if (num1 == num2 && num1 == num3)
            {
                Console.WriteLine("Estos numeros forma un triangulo equilatero");
            }
            else if (num2 == num1 || num2 == num3 || num1 == num3)
            {
                Console.WriteLine("Estos numeros forman un triangulo isoceles");
            }
            else
            {
                Console.WriteLine("Estos numeros forman un triangulo escaleno");
            }
        }




    }
}
