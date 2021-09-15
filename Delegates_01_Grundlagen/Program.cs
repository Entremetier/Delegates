using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* In Delegates können Verweise auf Methoden gespeichert werden und die Methoden können
 * auch über diese Delegates aufgerufen werden. Delegates können auch als Argumente an
 * Methoden übergeben werden.In anderen Programmiersprachen wie C und C++ werden
 * Delegates als "Funktionszeiger" (Function Pointer) bezeichnet.
 * 
 * Ein Delegate-Typ legt fest, welche Methoden in einer Delegate-Instanz gespeichert
 * werden können. Zur Laufzeit kann dann derselbe Delegate verwendet werden, um
 * verschiedene Methoden aufzurufen, wobei lediglich die Methode geändert werden muss,
 * auf die der Delegate zeigt. Die Methode, die über einen Delegate aufgerufen wird,
 * wird also zur Laufzeit und nicht zur Compilezeit festgelegt.
 * 
 * Wichtig ist aber, dass Delegate-Instanzen eines Delegate-Typs nur auf Methoden
 * verweisen können, die dieselbe Signatur und denselben Rückgabetyp aufweisen. Die
 * Methoden selbst dürfen sowohl statische Methoden, als auch Instanzmethoden sein.
 * 
 * Ein Delegate-Typ wird wie eine abstrakte Methode definiert, wobei statt des
 * Schlüsselworts "abstract" das Schlüsselwort "delegate" verwendet wird.
 * 
 * Syntax: [Zugriffsmodifizierer] delegate Rückgabetyp Delegatename (Parameterliste)
 * 
 * Delegate-Typen können direkt in einem Namespace oder auch in einer Klasse deklariert
 * werden. Ist der Delegate-Typ in einem Namespace deklariert, dann ist seine Sichtbar-
 * keit stdm. internal (wie bei Klassen und Interfaces). Ist der Delegate-Typ in einer
 * Klasse deklariert, dann ist seine Sichtbarkeit stdm. private (wie bei allen Membern).
 * 
 * Die wichtigsten Anwendungsgebiete von Delegates sind LINQ-Abfragen und die Ereignis-
 * behandlung (Event Handling) bei grafischen User Interfaces.
 */


namespace Delegates_01_Grundlagen
{
    //Per default hat der delegate im namespace den Zugriffsmodifiziere internal, in einer Klasse wäre er private.
    //Die Methoden die den delegat verwenden müssen die selben Parameter haben und den gleichen Typ beim Rückgabewert haben.
    //Delegate-Typ legt fest, wie die Methoden aufgebaut sein müssen damit sie einer Delgate-Instanz zugewiesen werden können.
    delegate int IntTransform(int wert);

    class Program
    {
        //Einen intwert verdoppeln
        static int Double(int value) => 2 * value;

        //Einen intwert quadrieren
        static int Square(int value) => value * value;

        static int AddOne(int value) => ++value;

        //Methode mit einem Delegate als Parameter.
        //Die Methode führt die beim Aufruf für den 1.Parameter angegebene Method aus.
        //Der 2.Parameter (value) ist der Parameter für die Methode, die aufgerufen wird.
        static int UseDelegate(IntTransform intDelegate, int value)
        {
            //Die als Delegate übergebene Methode ausführen.
            return intDelegate(value);
        }


        static void Main(string[] args)
        {
            //Zeigt im Speicher auf die Methode Double()
            //Einen Delegate (eine Delegateinstanz) erstellen und die Methode Double zuweisen.
            IntTransform intOp = new IntTransform(Double);

            //ODER einfacher

            IntTransform intOp2 = Double;

            //Die Methode Double() über den Delegate aufrufen
            int x = intOp.Invoke(4);

            //ODER einfacher

            x = intOp(4);
            Console.WriteLine("Verdoppelung von 4 = " + x);


            //Dem Delegate die Methode Square zuweisen...
            intOp = Square;

            //... und die Methode über den Delegate aufrufen
            x = intOp(4);
            Console.WriteLine("Quadrat von 4 = " + x);


            //Einen Delegate als Argument übergeben
            //----------------------------------------------

            x = UseDelegate(intOp, 6);
            Console.WriteLine(x);

            x = UseDelegate(new IntTransform(Double), 6);
            Console.WriteLine(x);

            //ODER

            x = UseDelegate(Double, 6);
            Console.WriteLine(x);

            Console.WriteLine(UseDelegate(AddOne,100));


            Console.ReadKey();
        }
    }
}
