/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Operators
{
    class Program
    {
        static void Main()
        {
            /* C# provides two operators to make it easier to work with nulls:
               the null coalescing operator and the null-conditional operator.  */
            /**************** NULL COALESCING OPERATOR **************************/
            /* The ?? operator is the null coalescing operator. It says "If the
               operand is non-null, give it to me; otherwise, give me a default
               value." For Example:                                             */
            string s1 = null;
            string s2 = s1 ?? "nothing";    // s2 evaluates to "nothing"
            /* If the lefthand expression is non-null, the righthand expression
               is never evaluated. The null coalescing operator also works with
               nullable value types (CH.4)                                      */
            /**************** NULL-CONDITIONAL OPERATOR *************************/
            /* The ?. operator is the null-conditional operator, and is new to 
               C#6. It allows you to call methods and access members just like 
               the standard dot operator, except that if the operand on the left
               is null, the expression evaluates to null instand of throwing a
               NullReferenceException:                                          */
            StringBuilder sb = null;
            string s = sb?.ToString();  // No error; s instead evaluates to null
            /* The last line is equivalent to:
                    string s = (sb == null ? null : sb.ToString());             */
            /* Upon encounting a null, the elvis operator (.?) short-circuits
               the remainder of the expression.                                 */
            StringBuilder SB = null;
            string S = SB?.ToString().ToUpper();    // S evaluates to null without error.
            /* Repeated use of .? is only necessary if the operand immediately
               to its left may be null.                                         */
            // The final expression must be capable of accepting a null.
            // The following is illegal:
            StringBuilder Sb = null;
            // int length = Sb?.ToString().Length; <- This is illegal: int cannot be null.
            // We can fix this with the use of nullable value types (CH.4)
            int? length = Sb?.ToString().Length;    // OK : int? can be null.
            /* You can also use the null-conditional operator to call a void method:
               someObject?.SomeVoidMethod();
               If someObject is null, this becomes a "no-operation" rather than 
               throwing a NullReferenceException.                               */
            /* The null-conditional operatoer can be used with the commonly used
               type members (CH.3) including methods, fields, properties, and 
               indexers. It also combines well with null coalescing operator:   */
            StringBuilder sB = null;
            string s3 = sB?.ToString() ?? "nothing"; // evaluates to "nothing"
        }
    }
}
