namespace RageCommunity.Library.Attributes
{
    public class DefectNativeAttribute : System.Attribute
    {
        /// <summary>
        /// The developer who found the defect.
        /// </summary>
        public string Developer { get; set; }

        /// <summary>
        /// A description of the defect.
        /// </summary>
        public string Description { get; set; }

        public DefectNativeAttribute(string developer, string description)
        {
            Developer = developer;
            Description = description;
        }
    }
}