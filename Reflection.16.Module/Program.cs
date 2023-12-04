using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection._16.Module
{
    class MyClass
    {
        public int MyObjects1 { get; set; }
        public string MyObjects2 { get; set; }
        public double MyObjects3 { get; set; }
    }
    public class Program
    {

        static void Main(string[] args)
        {

            /* 1.Получение списка методов класса Console с использованием рефлексии:*/

            /*  Type consoleType = typeof(Console);

              //  все методы класса Console
              MethodInfo[] methods = consoleType.GetMethods();

              foreach (MethodInfo method in methods)
              {
                  Console.WriteLine(method.Name);
              }*/

            // 2.Описание класса с несколькими свойствами и использование рефлексии для получения свойств и их значений:

            /*MyClass myObject = new MyClass();
            myObject.MyObjects1 = 42;
            myObject.MyObjects2 = "Hello, Reflection!";
            myObject.MyObjects3 = 3.14;

            Type myType = myObject.GetType();

            PropertyInfo[] properties = myType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object value = property.GetValue(myObject);
                Console.WriteLine($"{property.Name}: {value}");
            }*/

            // 3.Вызов метода Substring класса String с использованием рефлексии:

            /*string myString = "Hello, Reflection!";
            Type stringType = typeof(string);

            // метод Substring
            MethodInfo substringMethod = stringType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });

            object result = substringMethod.Invoke(myString, new object[] { 7, 5 });

            Console.WriteLine(result);*/

            // 4.Получение списка конструкторов класса List<T>:

            Type listType = typeof(List<>);

            ConstructorInfo[] constructors = listType.GetConstructors();

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor);
            }
        }
    }
}
