using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Ein Delegate-Typ kann generisch sein. Einen generischen Delgate-Typ erkennt man an
 * den spitzen Klammern nach dem Delegate-Namen. In den spitzen Klammern kann ein
 * Typparameter oder eine Liste von Typparametern angegeben werden. Typparameter können
 * in der Parameterliste und/oder als Rückgabetyp in einer Delegate-Typ Deklaration
 * verwendet werden.
 * 
 * Beim Erstellen der Delegate-Instanz muss der generische Delegate-Typ dann typisiert
 * werden. Die Delegate-Instanz kann dann nur auf Methoden verweisen, die dieselbe
 * Signatur und denselben Rückgabetyp wie die typisierte Delegate-Instanz besitzen,
 * oder wenn eine implizite Typumwandlung zwischen den jeweiligen Typen existiert.
 * 
 * Generische Delegates sind typsicher.
 */

namespace Delegates_03_Generic
{
    delegate T Transform<T>(T value);

    class Program
    {
        static int Double(int value) => 2 * value;
        static double Double(double value) => 2 * value;
        static int Square(int value) => value * value;
        static double Square(double value) => value * value;

        //static int UseDelegate(Transform<int> transform, int value) => transform(value);


        ////Überladen der UseDelegate
        //static double UseDelegate(Transform<double> transform, double value) => transform(value);


        //Anstelle der beiden obigen UseDelegate-Methoden kann man auch eine generische UseDelegate-Methode mit einem
        //generischen Delegate als Parameter verwenden
        static T UseDelegate<T>(Transform<T> genDelegate, T value) => genDelegate(value);


        static void Main(string[] args)
        {
            //Können nur Methoden zugewiesen werden die einen int-Wert als Parameter übernehmen und auch zurück geben
            Transform<int> intTransform = Double;

            Console.WriteLine("Das doppelte von 4 = " + intTransform(4));

            intTransform = Square;
            Console.WriteLine("Quadrat von 4 = " + intTransform(4));

            int x = UseDelegate(Double, 4);
            Console.WriteLine("Das doppelte von 4 = " + x);

            x = UseDelegate(Square, 4);
            Console.WriteLine("Quadrat von 4 = " + x);
            Console.WriteLine();


            //Verwenden des double-delegaten
            Transform<double> doubleTransform = Double;

            Console.WriteLine("Das doppelte von 12.5 = " + doubleTransform(12.5));

            doubleTransform = Square;
            Console.WriteLine("Quadrat von 4 = " + doubleTransform(12.5));

            double y = UseDelegate(Double, 12.5);
            Console.WriteLine("Das doppelte von 12.5 = " + y);

            y = UseDelegate(Square, 12.5);
            Console.WriteLine("Quadrat von 12.5 = " + y);





            Console.ReadKey();
        }
    }
}
