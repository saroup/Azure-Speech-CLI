// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Speech.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// UploadVcgFilesResponseV3
    /// </summary>
    public partial class UploadVcgFilesResponseV3
    {
        /// <summary>
        /// Initializes a new instance of the UploadVcgFilesResponseV3 class.
        /// </summary>
        public UploadVcgFilesResponseV3()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UploadVcgFilesResponseV3 class.
        /// </summary>
        public UploadVcgFilesResponseV3(IList<UploadVcgFileResponseV3> files)
        {
            Files = files;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "files")]
        public IList<UploadVcgFileResponseV3> Files { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Files == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Files");
            }
            if (Files != null)
            {
                foreach (var element in Files)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
