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
    /// PhoneResponseV3
    /// </summary>
    public partial class PhoneResponseV3
    {
        /// <summary>
        /// Initializes a new instance of the PhoneResponseV3 class.
        /// </summary>
        public PhoneResponseV3()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhoneResponseV3 class.
        /// </summary>
        public PhoneResponseV3(string phone, IList<string> features)
        {
            Phone = phone;
            Features = features;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "phone")]
        public string Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "features")]
        public IList<string> Features { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Phone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Phone");
            }
            if (Features == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Features");
            }
        }
    }
}