using System;


namespace F10Y.T0011
{
    /// <summary>
    /// Allows marking any member with an instance identity so that duplicates can be found.
    /// </summary>
    [SurveyAttributeMarker]
    [AttributeUsage(
        AttributeTargets.All, // Any member can be an instance.
        AllowMultiple = true, // Allow multiple identities.
        Inherited = false // Nothing is inherited.
        )]
    public class InstanceIdentityAttribute : Attribute
    {
        /// <summary>
        /// A unique label. (<see cref="Guid"/> values work well).
        /// </summary>
        public string Label { get; }


        public InstanceIdentityAttribute(
            string label)
        {
            this.Label = label;
        }
    }
}
