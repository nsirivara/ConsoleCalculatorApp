using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace ConsoleCalculatorApp
{
    public class Add
    {
        public string Description { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    public class Divide
    {
        public string Description { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    public class Multiply
    {
        public string Description { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    public class Operations
    {
        public List<Add> Add { get; set; }
        public List<Multiply> Multiply { get; set; }
        public List<Subtract> Subtract { get; set; }
        public List<Divide> Divide { get; set; }
        public List<Power> Power { get; set; }
    }

    public class Root
    {
        public Operations Operations { get; set; }
    }

    public class Subtract
    {
        public string Description { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }

    public class Power
    {
        public string Description { get; set; }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
    }
}

