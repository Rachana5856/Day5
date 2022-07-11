using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = Type.GetType("Reflection.Customer");
            Console.WriteLine("FullName is ={0}", t.FullName);
            Console.WriteLine("Name is ={0}", t.Name);
            Console.WriteLine("NameSpace is ={0}", t.Namespace);

            //Properties of customer------------------------------
            Console.WriteLine("Properties of Customer");
            PropertyInfo[] properties=t.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+property.Name);
               
            }

            //Methods of customer------------------------------

            Console.WriteLine("");
            Console.WriteLine("Methods of Customer");
            MethodInfo[] methods = t.GetMethods();
            foreach (MethodInfo method in methods )
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);

            }

            //Constructors of customer---------------------------------
            Console.WriteLine("");
            Console.WriteLine("Construcor of Customer");
            ConstructorInfo[] constructors = t.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());

            }
            Console.ReadLine();
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, String Name)
        {
            this.Id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }

        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
