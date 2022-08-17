using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System;


namespace ConsoleCalculatorApp
{

    [XmlRoot("Operations")]
    public class Operation
    {
        [XmlElement("Add")]
        public List<UserRecord> AddRecords { get; set; }

       [XmlElement("Multiply")]
        public List<UserRecord> MultiplyRecords { get; set; }

        [XmlElement("Divide")]
        public List<UserRecord> DivideRecords { get; set; }

        [XmlElement("Subtract")]
        public List<UserRecord> SubtractRecords { get; set; }

        [XmlElement("Power")]

        public List<UserRecord> PowerRecords { get; set; }
    }


    public class UserRecord
    {
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("Value1")]
        public double Value1 { get; set; }
        [XmlElement("Value2")]
        public double Value2 { get; set; }
             
        public string getUserName()
        { return Description.Split(";")[0]; }

        public string getOperationName()
        { return Description.Split(";")[1]; }

        public string getMiscInfo()
        { return Description.Split(";")[2]; }

      
    }
}