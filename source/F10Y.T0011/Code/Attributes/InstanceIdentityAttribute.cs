using System;


namespace F10Y.T0011
{
    /// <summary>
    /// Allows marking any member with an instance identity so that duplicates can be found.
    /// </summary>
    [SurveyAttributeMarker]
    [AttributeUsage(AttributeTargets.All)]
    public class InstanceIdentityAttribute : Attribute
    {
        public string Label { get; }


        public InstanceIdentityAttribute(
            string label)
        {
            this.Label = label;
        }
    }
}
