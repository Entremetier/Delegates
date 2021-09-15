using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Oft besteht die einzige Anwendung einer Methode darin, dass sie von einer Delegate-
 * Instanz referenziert wird. Die Methode wird nie selbst, sondern immer nur über den
 * Delegate aufgerufen. In so einem Fall kann man darauf verzichten, eine separate
 * Methode zu schreiben und statt dessen eine anonyme Methode verwenden.
 * 
 * Eine anonyme Methode besitzt keinen Namen. Sie kann nur über eine Delegate-Instanz
 * aufgerufen werden und muss beim Instanziieren des Delegates definiert werden. Das
 * erfolgt durch die Übergabe eines unbenannten Codeblocks an den Delegate-Konstruktor.
 * 
 * Anonyme Methoden werden wie normale Methoden definiert. Der Methodenname wird jedoch
 * durch das Schlüsselwort delegate ersetzt. Die Parameterliste der anonymen Methode
 * muss mit der Parameterliste des Delegate-Typs übereinstimmen. Und je nachdem, ob der
 * Delegate-Typ einen Rückgabewert definiert oder nicht, muss auch die anonyme Methode
 * einen passenden Wert mit einer return-Anweisung zurückliefern oder nicht.
 * 
 * Der Vorteil von anonymen Methoden liegt in der Vereinfachung des Codes. Für eine
 * Methode, die nur an eine Delegate-Instanz übergeben wird, besteht kein Grund, eine
 * separate Methode zu deklarieren.
 * 
 * Anonyme Methoden wurden mit C# 2.0 eingeführt. Mit C# 3.0 wurden dann die sog.
 * Lambda-Ausdrücke (Lambda Expressions) eingeführt, die das Konzept der anonymen
 * Methoden verbessern und die in neuen Programmen verwendet werden sollen. Um alte,
 * bestehende Programme zu verstehen, ist aber auch die Kenntnis von anonymen Methoden
 * wichtig.
 */

namespace Delegates_06_AnonymeMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
