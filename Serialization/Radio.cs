using System;

namespace Serialization
{
    [Serializable]
    public class Radio
    {
        public bool HasTweeters;
        public bool HasSubWoofers;
        public double[] StationPresets;
        [NonSerialized]
        public string RadioId = "XF-552RR6";
    }
}
