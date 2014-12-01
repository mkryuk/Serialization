using System;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Radio
    {
        public bool HasTweeters;
        public bool HasSubWoofers;
        public double[] StationPresets;
        [XmlAttribute]
        public string RadioId = "XF-552RR6";
    }
}
