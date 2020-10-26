using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FileIODemo
{
    class BinarySerialisation
    {
        public void Serialisation()
        {
            Demo sample = new Demo();
            FileStream fileStream = new FileStream(@"C:\Users\Gharat\source\repos\Sample\sample1.txt",FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, sample);
        }
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"C:\Users\Gharat\source\repos\Sample\sample1.txt", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializedSampleDemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"ApplicationName {deserializedSampleDemo.ApplicationName} ---ApplicationId  {deserializedSampleDemo.ApplicationId}");
        }
    }
    [Serializable]
    public class Demo
    {
        public string ApplicationName { get; set; } = "Binary Serialize";
        public int ApplicationId { get; set; } = 1001;
    }
}
