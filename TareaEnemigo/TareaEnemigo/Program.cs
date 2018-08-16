using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEnemigo
{
    class Enemigo
    {
        static void Main(string[] args)
        {
            // We created a contact instance
            Enemigo enemigouno = new Enemigo();
            enemigouno.NombreEnemigo = "Mauricio";
            enemigouno.PosicionX = "32";
            enemigouno.PosicionY = "8";
            enemigouno.Puntos = "230";
            

            Console.WriteLine("Nombre:" + enemigouno.NombreEnemigo);

            Console.WriteLine("Posicion X:" + enemigouno.PosicionX);

            Console.WriteLine("Posicion Y:" + enemigouno.PosicionY);

            Console.WriteLine("Puntos:" + enemigouno.Puntos);

           

            Console.ReadLine();
            
        }
    }
}
