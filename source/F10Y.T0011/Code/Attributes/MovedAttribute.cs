using System;


namespace F10Y.T0011
{
    /// <summary>
    /// Allows marking any member with a destintaion to which a member has moved.
    /// </summary>
    [SurveyAttributeMarker]
    [AttributeUsage(AttributeTargets.All)]
    public class MovedAttribute : Attribute
    {
        public string Destination { get; }


        public MovedAttribute(
            string destination)
        {
            this.Destination = destination;
        }
    }
}
