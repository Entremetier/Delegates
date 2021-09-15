using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Neben den Delegate-Typen Func und Action gibt es den built-in Delegate-Typ Predicate.
 * Siehe MSDN Predicate<T> Delegate.
 * 
 * Der Delegate-Typ Predicate (Aussage) ist in der Bibliothek mscorlib.dll im Namespace System
 * wie folgt definiert:
 * 
 *    public delegate bool Predicate<T>(T obj);
 * 
 * Predicate<T> stellt einen generischen Delegate-Typ für Methoden dar, die prüfen, ob
 * verschiedene Kriterien für das angegebene Objekt vom Typ T erfüllt sind oder nicht.
 * Sind die Kriterien erfüllt, wird true andernfalls false zurückgeliefert.
 */

namespace Delegates_05_Predicate
{
    class Program
    {
        static bool IsOnlyUppercase(string txt)
        {
            foreach (char item in txt)
            {
                if (!char.IsUpper(item))
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsLastCharN(string txt) => txt.EndsWith("n", true, null) ? true : false;

        static bool CheckString(Predicate<string> checkMethode, string text)
        {
            bool checkResult = checkMethode(text);
            //Console.WriteLine($"Der Check {checkMethode.Method.Name} (\"{text}\") liefert {checkResult}");

            return checkResult;

        }

        static void Main(string[] args)
        {
            string txt = "Hallo Welt";

            Console.WriteLine(IsLastCharN(txt));


            Predicate<string> stringTest = IsOnlyUppercase;

            bool result = stringTest("NNN");
            Console.WriteLine(result);

            stringTest = IsLastCharN;
            result = stringTest("Saufen");
            Console.WriteLine(result);

            //Die Methode IsOnlyUppercase() als Argument verwenden
            result = CheckString(IsOnlyUppercase, txt);

            //Die Methode IsLastCharN() als Argument verwenden
            CheckString(IsLastCharN, "Saufen");


            //Statt des Predicate kann auch eine Function verwendet werden.
            //Diese Function wird so häufig verwendet, dass dafür der eigene Delegate-Typ Predicate eigeführt wurde.
            //Bei Predicate muss der bool nicht angegeben werden da er sowieso einen bool zurückgibt.
            Func<string, bool> func = IsLastCharN;

            Console.WriteLine(func(txt));

            func = IsOnlyUppercase;
            Console.WriteLine(func("AAAa"));

            Console.ReadKey();
        }
    }
}
