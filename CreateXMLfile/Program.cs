using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CreateXMLfile
{
    class Program
    {
        static void Main(string[] args)
        {

            string xmlFile = "C:\\TechnicalExp\\websites\\MVC-Sites\\Employee.xml";
            XmlTextWriter xmlWriter = new XmlTextWriter(xmlFile, Encoding.UTF8);

            xmlWriter.Formatting = Formatting.Indented;


            //Create Header node for XML
            xmlWriter.WriteStartDocument();

            xmlWriter.WriteComment("Creating an XML file using C#");

            //Write Starting node for Employee records i.e Employees
            xmlWriter.WriteStartElement("Employees");

            //Create loop to accept input from user through consol

            for (int i = 1; i <= 2; i++) {

                //First Node 
                xmlWriter.WriteStartElement("Employee");

                //Employee Node has three Attributes
                Console.WriteLine("Enter Id for Employee " + i);
                xmlWriter.WriteElementString("ID", Console.ReadLine());

                Console.WriteLine("Enter FullName for Employee " + i);
                xmlWriter.WriteElementString("FullName", Console.ReadLine());

                Console.WriteLine("Enter Department for Employee " + i);
                xmlWriter.WriteElementString("Department", Console.ReadLine());

                xmlWriter.WriteEndElement();

            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
            xmlWriter.Close();
            
        }
    }
}