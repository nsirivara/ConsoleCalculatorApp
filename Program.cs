using System.Xml;
using System.Xml.Serialization;
using System;

namespace ConsoleCalculatorApp
{

    public class Program
    {
        enum FileType { XML, JSON };
        const string xmlFile = @"math.xml";
        const string jsonFile = @"math.json";
        public static void Main(string[] args)

        {
            //introduce a command line switch to pick file type .setting to xml for test

            FileType _fType = FileType.XML;
            FileParser p = new FileParser();

            
            //if filetype is a xml then parse xml file
            if (_fType == FileType.XML) p.ProcessXML(xmlFile);

            //if filetype is a json then parse json file
            if (_fType == FileType.JSON) p.ProcessJSON(jsonFile);

            System.Console.Read();


        }
    }
}


