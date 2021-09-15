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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
