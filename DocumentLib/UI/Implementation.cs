using DocumentLib.Attributes;
using DocumentLib.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLib.UI
{
    public static class Implementation
    {
        public static void GetDocs(Type classtype)
        {
            //load the assembly
            var currentAssembly = Assembly.GetExecutingAssembly();
            var currentAssembly0 = currentAssembly.GetTypes();
            foreach (var myTypes in currentAssembly0)
            {
                //Console.WriteLine(ty);
                // Console.WriteLine(ty.FullName);
                //Console.WriteLine(ty.FindMembers);
                Console.WriteLine(myTypes.Name);
            }
            Console.WriteLine("\n\n***************************");
/*            var oneTypeFromcurrentAssembly = currentAssembly.GetType("Domain.Beazo", false);
            Console.WriteLine("one type from assembly {0}", oneTypeFromcurrentAssembly);*/


            Console.WriteLine("*******************members info***********");
            ListProperties(classtype);
            ListMethod(classtype);
            DisplayClasses(classtype);
            
            




        }
        //methods


        public static void DisplayClasses(Type classtype)
        {
            Console.WriteLine("Assembly: {0}", Assembly.GetExecutingAssembly());
            Console.WriteLine("\nClass: \n\n{0}", classtype.Name);

            object[] classAttr = classtype.GetCustomAttributes(true);

            foreach (Attribute item in classAttr)
            {
                if (item is DocumentAttribute)
                {
                    DocumentAttribute doc = (DocumentAttribute)item;
                    Console.WriteLine("\nDescription:\n\t{0}", doc.Description);
                }
            }
        }

        public static void ListProperties(Type classtype)
        {
            Console.WriteLine("\n\nProperties: ");
            Console.WriteLine();

            PropertyInfo[] properties = classtype.GetProperties();

            for (int i = 0; i < properties.GetLength(0); i++)
            {
                object[] propAttr = properties[i].GetCustomAttributes(true);

                foreach (Attribute item in propAttr)
                {
                    if (item is DocumentAttribute)
                    {
                        DocumentAttribute doc = (DocumentAttribute)item;
                        Console.WriteLine("{0}\nDescription:\n\t{1}\nInput:\n\t{2}\n", properties[i].Name, doc.Description, doc.Input);
                    }
                }
            }
        }

        public static void ListMethod(Type classtype)
        {
            Console.WriteLine("\nMethods:\n");
            MethodInfo[] methods = classtype.GetMethods();


            for (int i = 0; i < methods.GetLength(0); i++)
            {
                object[] methAttr = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in methAttr)
                {
                    if (item is DocumentAttribute)
                    {
                        DocumentAttribute doc = (DocumentAttribute)item;
                        Console.WriteLine("{0}\nDescription:\n\t{1}\nInput:\n\t{2}", methods[i].Name, doc.Description, doc.Input, doc.Output);
                    }
                }
            }
        }
    }
    }

