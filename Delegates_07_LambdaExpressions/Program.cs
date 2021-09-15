using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Mit C# 3.0 wurden die sogenannten Lambda-Ausdrücke (Lambda Expressions) eingeführt,
 * die das Konzept der anonymen Methoden verbessern. In neuen Programmen sollen nur
 * mehr Lambda-Ausdrücke (statt anonymen Methoden) verwendet werden.
 * 
 * Ein Lambda-Ausdruck hat die folgende Form:
 * 
 *    (Parameterliste) => Ausdruck oder Anweisungsblock
 * 
 * => ist der sog. Lambda-Operator. Links von => stehen die Parameter, rechts davon ein
 * Ausdruck, der ausgewertet wird und das Resultat des Lambda-Ausdrucks (= Rückgabewert
 * der anonymen Methode) darstellt.
 * 
 * Besteht die Parameterliste aus genau 1 Parameter, dann können die runden Klammern
 * weggelassen werden. Besitzt der Lambda-Ausdruck keinen Parameter, dann muss man
 * leere runde Klammern vor dem Lambda-Operator angeben: () => ... .
 * 
 * Besteht der Ausdruck aus mehreren Anweisungen, dann muss ein Codeblock {...}
 * verwendet und der Rückgabewert mit return zurückgegeben werden.
 */

namespace Delegates_07_LambdaExpressions
{
    //Delegate-Typ mit einem int-Parameter und einem Rückgabewert vom Typ int
    delegate int Increment(int value);      //Func<int, int>

    class Program
    {
        static void Main(string[] args)
        {
            //Eine Delegate-Instanz erstellen und und aufrufen, die ihren Parameter um 2 erhöht
            //----------------------------------------------------------------------------------

            //Als anonyme Methode
            Increment incrementMitAnonymerMethode = delegate (int value)
            {
                return value + 2;
            };

            int x = incrementMitAnonymerMethode(4);
            Console.WriteLine(x);


            //Als lambda
            Increment incrementMitLambda = value => value + 2;

            x = incrementMitLambda(3);
            Console.WriteLine(x);

            //Beide Varianten (anonym und lambda) machen das selbe. Die Lambda-Schreibweise ist kompakter.


            //Die Delegate-Instanz in einer Schleife verwenden, um die Iterationsvariable am Ende der Schleife um 2 zu erhöhen
            //----------------------------------------------------------------------------------------------------------------

            int y = -10;

            while (y <= 0)
            {
                Console.Write(y + " ");
                y = incrementMitLambda(y);
            }

            Console.WriteLine("\n");

            //Eine Delegate-Instance erstellen und aufrufen, die true zurückgibt wenn ihr Parameter gerade ist und andernfalls 
            //false zurückgibt
            //----------------------------------------------------------------------------------------------------------------

            //Delegate-Instanze anonym
            //Predicate<int> isEvenAnonym = delegate (int value)
            //{
            //    if (value % 2 == 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //};

            //ODER KÜRZER

            Predicate<int> isEvenAnonym = delegate (int value)
            {
                return value % 2 == 0;
            };


            Console.WriteLine("Anonym: " + isEvenAnonym(3));

            //Delegate-Instanze Lambda-Ausdruck und Codeblock
            //Predicate<int> isEvenLambda = value =>
            //{
            //    if (value % 2 == 0)
            //    {
            //        return true;
            //    }
            //    return false;
            //};

            //ODER KÜRZER

            //Delegate-Instanze Lambda-Ausdruck ohne Codeblock
            Predicate<int> isEvenLambda = value => value % 2 == 0;

            Console.WriteLine("Lambda: " + isEvenLambda(4));
            Console.WriteLine();


            //Delegate-Instanze in einer Schleife aufrufen, um zu prüfen ob die Iterationsvariable gerade ist oder nicht
            //-----------------------------------------------------------------------------------------------------------

            for (int i = 0; i <= 10; i++)
            {
                if(isEvenLambda(i)) Console.WriteLine(i + " ist gerade");
            }

            Console.ReadKey();
        }
    }
}
