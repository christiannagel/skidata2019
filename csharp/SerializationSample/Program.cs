using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace SerializationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new PersonDC() { FirstName = "Tom", LastName = "Turbo" };
            string json = JsonConvert.SerializeObject(p1);

            var p2 = JsonConvert.DeserializeObject<PersonDC>(json);

            DataContractSerializer serializer1 = new DataContractSerializer(typeof(PersonDC));
            // serializer1.WriteObject()
        }
    }
}
