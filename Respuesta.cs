using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ7
{
    public class Respuesta:triangulo
    {
        private String respu { get; set; }

        public Respuesta()
        {
            this.respu = "";
        }
        public void imprimir()
        {
            do
            {
             proceso();
            } while (respu == "s" || respu == "S");
        }

    }
}
