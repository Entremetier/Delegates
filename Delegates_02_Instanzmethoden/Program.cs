using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Im Projekt Delegates_01_Grundlagen wurden statische Methoden über einen Delegate
 * aufgerufen. Delegates können aber auch auf Instanzmethoden verweisen. Dabei muss der
 * Delegate über eine Objekt-Referenz auf die Methode verweisen.
 */

namespace Delegates_02_Instanzmethoden
{
    delegate int IntTransform(int value);

    class IntOperations
    {
        public int Double(int value) => 2 * value;
        public int Square(int value) => value * value;
        public int UseDelegate(IntTransform intTransform, int value) => intTransform(value);
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Eine Instanz der Klasse IntOperations erstellen
            IntOperations intOperations = new IntOperations();

            //Eine Delegate-Instanz erstelle und dieser die (Instanz)-Methode zuweise
            IntTransform intOp = intOperations.Double;

            //Die (Instanz)-Methode Double über den Delegate aufrufen
            int x = intOp(4);
            Console.WriteLine(x);

            //Dem Delegate die Methode Square zuweisen
            intOp = intOperations.Square;
            x = intOp(4);
            Console.WriteLine(x);


            //Einen Delegate als Argument verwenden
            //-------------------------------------

            Console.WriteLine(intOperations.UseDelegate(intOp, 6));
            Console.WriteLine(intOperations.UseDelegate(intOperations.Double, 6));
        }
    }
}
