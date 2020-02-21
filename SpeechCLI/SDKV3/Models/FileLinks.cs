// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Speech.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// FileLinks
    /// </summary>
    public partial class FileLinks
    {
        /// <summary>
        /// Initializes a new instance of the FileLinks class.
        /// </summary>
        public FileLinks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileLinks class.
        /// </summary>
        /// <param name="files">The location to get all files of this
        /// entity</param>
        public FileLinks(string files = default(string))
        {
            Files = files;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the location to get all files of this entity
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public string Files { get; private set; }

    }
}