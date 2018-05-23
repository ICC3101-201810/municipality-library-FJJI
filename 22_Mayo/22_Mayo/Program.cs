using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _22_Mayo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly archivoAssembly = Assembly.LoadFile(@"C:\Users\Francisco\Desktop\Proyectos POO\22_Mayo\22_Mayo\ClassLibrary2.dll");
            
            foreach (Type type in archivoAssembly.GetTypes())
            {
                if (type.IsClass) Console.WriteLine("class");
                else if (type.IsInterface) Console.WriteLine("interface");
                else Console.WriteLine("otro tipo");
                Console.WriteLine(type.Name);
                MethodInfo[] properties = type.GetMethods();
                //Console.WriteLine("(");
                //Console.Write(type.Attributes);
                //Console.WriteLine(")");
                Console.WriteLine("metodos: ");
                //foreach (Attribute atr in )
                foreach (MethodInfo prop in properties)
                {
                    Console.WriteLine("\t" + prop.Name);
                    //Console.WriteLine("\t\t" + );
                    ParameterInfo[] parameters = prop.GetParameters();

                    //Console.WriteLine("\t\t" + prop.ReturnParameter);
                    if (parameters != null)
                    {
                        foreach (ParameterInfo para in parameters)
                        {
                            //Console.WriteLine("\t\t" + para.Attributes);
                            Console.WriteLine("+" + prop.Name + "(" + para.Attributes + ") : " + prop.ReturnParameter);
                        }
                    }
                    else
                    {
                        prop.
                    }
                  //  Console.WriteLine("+" + prop.Name+ "("+)
                }

                Console.WriteLine();
                


            }

            Console.ReadLine();
            Console.ReadKey();
        }

    }
}
