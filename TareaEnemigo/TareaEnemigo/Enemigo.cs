using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEnemigo
{
    class Enemigo
    {
        // auto properties 
        public string NombreEnemigo { get; set; }
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }
        public int Puntos { get; set; }

        //Properties
        private int _puntos;
        public int puntos
        {
            get {
                return _puntos;
            }
            set {
                if (value > 100)
                {
                    _puntos = value;

                }
                else
                {
                    Console. WriteLine("Puntos insuficientes");
                }
                
               
            }
        }
    }
}
