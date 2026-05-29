using CarreraCaballos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace ProtecoPOO.Ruleta
{
    public class Ruleta : Juego
    {
        private Random random = new Random();
        public List<int> num = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 0 };
        public Apuesta ApuestaRul { get; set; }
        public Ruleta(string nombre, int juegoId) : base(nombre, juegoId) { }
        public int Girar() => num[random.Next(num.Count)];

        public string Color(int n)
        {
            if (n == 0) return "Verde";
            int[] rojos = { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34 };
            if (rojos.Contains(n))
            {
                return "Rojo";
            }
            else
            {
                return "Negro";
            }
        }
        public string EvaluarResultado(int resultadoGiro)
        {
           
            if (ApuestaRul.Numero != -1)
            {
                if (ApuestaRul.Numero == resultadoGiro)
                {
                    return "GANASTE";
                }
                else
                {
                    return "PERDIO";
                }
            }
            else
            {
                if (ApuestaRul.Color == Color(resultadoGiro))
                {
                    return "GANASTE";
                }
                else
                {
                    return "PERDIO";
                }
            }
        }
    }
}

