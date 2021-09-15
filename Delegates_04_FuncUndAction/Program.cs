using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Generische Delegates erlauben es, einen kleinen Satz von Delegates zu schreiben,
 * die so allgemein sind, dass sie mit Methoden beliebigen Rückgabetyps und einer
 * praktikablen Anzahl von Argumenten funktionieren. Das .Net Framework stellt solche
 * Delegates im Namespace System zur Verfügung. Es handelt sich dabei um die Delegates
 * Func und Action mit entsprechenden Überladungen:
 * 
 *    Func    ist ein generischer Delegate für Methoden mit Rückgabewert
 *    Action  ist ein generischer Delegate für Methoden ohne Rückgabewert
 * 
 * Die Func und Action Delegate-Typen sind in den Bibliotheken mscorlib.dll (für die
 * Parameter T1 bis T8) und System.Core.dll (für die Parameter T9 bis T16) jeweils im
 * Namespace System wie folgt definiert:
 * 
 *    public delegate TResult Func<TResult>();
 *    public delegate TResult Func<T, TResult>(T arg);
 *    public delegate TResult Func<T1, T2, TResult>(T1 arg1, T2 arg2);
 *    public delegate TResult Func<T1, T2, T3, TResult>(T1 arg1, T2 arg2, T3 arg3);
 *    etc.
 *    
 *    public delegate void Action();
 *    public delegate void Action<T>(T obj);
 *    public delegate void Action<T1, T2>(T1 arg1, T2 arg2);
 *    public delegate void Action<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);
 *    etc.
 * 
 * Diese Delegates sind äußerst allgemein und decken einen Großteil der praktischen
 * Szenarien ab.
 */

namespace Delegates_04_FuncUndAction
{
    class Program
    {
        static int Double(int value) => 2 * value;
        static int Square(int value) => value * value;

        static int UseDelegate(Func<int, int> intDelegate, int value) => intDelegate(value);

        static void Main(string[] args)
        {
            //Eine Delegate-Instanz vom Typ Func<int, int> erstellen und dieser die Methode Double zuweisen
            Func<int, int> intOp = Double;

            int x = intOp(4);       //Die Methode Double über die Delegate-Instanz aufrufen
            Console.WriteLine("Das doppelte von 4 = " + x);

            intOp = Square;      //Der Delegate-Instanz die Methode Square zuweisen
            x = intOp(4);        //Die Methode Square über die Delegate-Instanz aufrufen
            Console.WriteLine("Quadrat von 4 = " + x);      

            x = UseDelegate(Double, 4);
            Console.WriteLine("Das doppelte von 4 = " + x);

            x = UseDelegate(Square, 4);
            Console.WriteLine("Quadrat von 4 = " + x);


            Console.ReadKey();
        }
    }
}
