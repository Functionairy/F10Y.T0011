using System;


namespace F10Y.T0011
{
    /// <summary>
    /// Allows marking any member to that it is ignored during the code survey process.
    /// </summary>
    [SurveyAttributeMarker]
    [AttributeUsage(AttributeTargets.All)]
    public class IgnoreAttribute : Attribute
    {
        // Do not include any is-X logic. To not ignore something, just remove the ignore element.
    }
}
