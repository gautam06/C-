using System;
using System.Collections;
using System.Reflection;

namespace ConsoleApplication4
{

    public class IsTestedAttribute : Attribute
    {
        public override string ToString()
        {
            return "Is Tested";
        }
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string name)
        {
            this.name = name;
            this.version = 0;
        }

        // This property is readonly (it has no set accessor)
        // so it cannot be used as a named argument to this attribute.
        public string Name
        {
            get { return name; }
        }

        // This property is read-write (it has a set accessor)
        // so it can be used as a named argument when using this
        // class as an attribute class.
        public int Version
        {
            get { return version; }
            set { version = value; }
        }

        public override string ToString()
        {
            string value = "Author : " + Name;
            if (version != 0)
            {
                value += " Version : " + Version.ToString();
            }
            return value;
        }

        private string name;
        private int version;
    }

    [Author("Joe Programmer")]
    internal class Account
    {
        [IsTested]
        public void AddOrder(Order orderToAdd)
        {
            orders.Add(orderToAdd);
        }

        private ArrayList orders = new ArrayList();
    }

    
    [Author("Jane Programmer", Version = 2), IsTested()]
    internal class Order
    {
        
    }

    internal class MainClass
    {
        private static bool IsMemberTested(MemberInfo member)
        {
            foreach (object attribute in member.GetCustomAttributes(true))
            {
                if (attribute is IsTestedAttribute)
                {
                    return true;
                }
            }
            return false;
        }

        private static void DumpAttributes(MemberInfo member)
        {
            Console.WriteLine("Attributes for : " + member.Name);
            foreach (object attribute in member.GetCustomAttributes(true))
            {
                Console.WriteLine(attribute);
            }
        }

        public static void Main()
        {
            // display attributes for Account class
            DumpAttributes(typeof (Account));

            // display list of tested members
            foreach (MethodInfo method in (typeof (Account)).GetMethods())
            {
                if (IsMemberTested(method))
                {
                    Console.WriteLine("Member {0} is tested!", method.Name);
                }
                else
                {
                    Console.WriteLine("Member {0} is NOT tested!", method.Name);
                }
            }
            Console.WriteLine();

            // display attributes for Order class
            DumpAttributes(typeof (Order));

            // display attributes for methods on the Order class
            foreach (MethodInfo method in (typeof (Order)).GetMethods())
            {
                if (IsMemberTested(method))
                {
                    Console.WriteLine("Member {0} is tested!", method.Name);
                }
                else
                {
                    Console.WriteLine("Member {0} is NOT tested!", method.Name);
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

    /*Output
        Attributes for : Account
        Author : Joe Programmer
        Member AddOrder is tested!
        Member ToString is NOT tested!
        Member Equals is NOT tested!
        Member GetHashCode is NOT tested!
        Member GetType is NOT tested!

        Attributes for : Order
        Author : Jane Programmer Version : 2
        Is Tested
        Member ToString is NOT tested!
        Member Equals is NOT tested!
        Member GetHashCode is NOT tested!
        Member GetType is NOT tested!
    */
}