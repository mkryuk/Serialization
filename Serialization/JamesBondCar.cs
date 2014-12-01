using System;
using System.Runtime.Serialization;

namespace Serialization
{
    [Serializable]
    public class JamesBondCar:Car,ISerializable
    {
        public bool CanFly;
        public bool CanSubmerge;

        public JamesBondCar()
            :this(false,false,"")
        {            
        }

        public JamesBondCar(bool canFly = false, bool canSubmerge = false, string radioId = "")
        {
            CanFly = canFly;
            CanSubmerge = canSubmerge;
            TheRadio.RadioId = radioId;
        }

        [OnSerialized]
        private void OnSerialization(StreamingContext context)
        {
            Console.WriteLine("Serialized");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
