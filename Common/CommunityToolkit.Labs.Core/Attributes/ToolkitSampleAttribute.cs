using System;

namespace CommunityToolkit.Labs.Core.Attributes
{
    /// <summary>
    /// Contains the registratino data for a toolkit sample project.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ToolkitSampleAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of <see cref="ToolkitSampleAttribute"/>.
        /// </summary>
        public ToolkitSampleAttribute(string displayName, string description)
        {
            DisplayName = displayName;
            Description = description;
        }

        /// <summary>
        /// The display name for this sample page.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// The description for this sample page.
        /// </summary>
        public string Description { get; set; }
    }
}
