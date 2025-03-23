using System;

using F10Y.T0000;


namespace F10Y.T0011
{
    /// <summary>
    /// Marks any code element for inclusion in a survey. (Used for marking attributes as survey attributes.)
    /// </summary>
    /// <remarks>
    /// The survey attribute is useful for surveying assemblies and code, then building a catalogue of survey result code elements..
    /// </remarks>
    [MarkerAttributeMarker] // This marker attribute is itself a marker attribute.
    [AttributeUsage(AttributeTargets.All, // Allow all elements to be surveyed.
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors all use the marker type.
    )]
    public class SurveyAttributeMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a survey attribute.
        /// This is useful for marking types that end up canonical survey attribute code file locations, but are not actually survey attributes.
        /// </summary>
        public bool Is_SurveyAttribute { get; }


        public SurveyAttributeMarkerAttribute(
            bool is_MarkerAttribute = true)
        {
            this.Is_SurveyAttribute = is_MarkerAttribute;
        }
    }
}
