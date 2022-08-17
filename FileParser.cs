
using System.Xml.Serialization;
using System.IO;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleCalculatorApp
{
    public class FileParser
    {
        public FileParser()
        { }
        public void ProcessXML(string _fname)
        {

            try
            {
                //deserialize math.xml 
                Operation operation;
                var xs = new XmlSerializer(typeof(Operation));
                using (var fs = new FileStream(_fname, FileMode.Open))
                    operation = (Operation)xs.Deserialize(fs);
                



                foreach (var rec in operation.AddRecords)
                    System.Console.WriteLine(rec.getUserName() + " -" + rec.getOperationName() + "- " + rec.Value1 + "+" + rec.Value2 + "=" +
                    (rec.Value1+rec.Value2));

                foreach (var rec in operation.MultiplyRecords)
                    System.Console.WriteLine(rec.getUserName() + " -" + rec.getOperationName() + "- " + rec.Value1 + "*" + rec.Value2 + "=" +
                    (rec.Value1*rec.Value2));

                foreach (var rec in operation.DivideRecords)
                    System.Console.WriteLine(rec.getUserName() + " -" + rec.getOperationName() + "- " + rec.Value1 + "/" + rec.Value2 + "=" +
                    rec.Value1/rec.Value2);

                foreach (var rec in operation.SubtractRecords)
                    System.Console.WriteLine(rec.getUserName() + " -" + rec.getOperationName() + "- " + rec.Value1 + "-" + rec.Value2 + "=" +
                    (rec.Value1-rec.Value2));
            }

            catch (Exception e) { System.Console.WriteLine(e.Message); }

        }

        public void ProcessJSON(string _fname) 
        {
            try
            {
                string json = File.ReadAllText(_fname);

                Operations operations = JsonSerializer.Deserialize<Operations>(json, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch(Exception e) { System.Console.WriteLine(e.Message); }
            
        }

    }
}