using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SerializationSample
{
    [Serializable]
    public class PersonBin : ISerializable
    {
        public PersonBin()
        {

        }

        // deserialization
        internal PersonBin(SerializationInfo info, StreamingContext context)
        {

        }
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName { get; set; }

        // serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context) => throw new NotImplementedException();
    }
}
