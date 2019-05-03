using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationSample
{
    [DataContract]
    public class PersonDC
    {
        [DataMember]
        [JsonIgnore]
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [DataMember()]
        public string LastName { get; set; }

    }
}
