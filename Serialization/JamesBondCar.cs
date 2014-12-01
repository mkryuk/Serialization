using System;

namespace Serialization
{
    [Serializable]
    public class JamesBondCar:Car
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
    }
}
