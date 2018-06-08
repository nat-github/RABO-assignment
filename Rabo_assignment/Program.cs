using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Rabo_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string _inputXLFile = ConfigurationSettings.AppSettings["InputFile"];
            string _inputXMLFile = ConfigurationSettings.AppSettings["InputXML"];
            string _inputXMLFile_Normal = ConfigurationSettings.AppSettings["InputXML_normal"];
            Excel_Read ER = new Excel_Read();
            ER._inputFile(_inputXLFile);
            #region
            //XML_Read XR = new XML_Read();
            //XR.ReadXML(_inputXMLFile_Normal);
            #endregion
            XML_Linq xq = new XML_Linq();
            xq.XML_read();
            Console.WriteLine("Completed");
            Logging.log_message("Completed");
            Console.Read();
        }
    }
}
