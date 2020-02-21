// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Speech.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ModelCopy
    /// </summary>
    public partial class ModelCopy
    {
        /// <summary>
        /// Initializes a new instance of the ModelCopy class.
        /// </summary>
        public ModelCopy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelCopy class.
        /// </summary>
        /// <param name="targetSubscriptionKey">The subscription key of the
        /// subscription that is target of the copy operation</param>
        public ModelCopy(string targetSubscriptionKey)
        {
            TargetSubscriptionKey = targetSubscriptionKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the subscription key of the subscription that is
        /// target of the copy operation
        /// </summary>
        [JsonProperty(PropertyName = "targetSubscriptionKey")]
        public string TargetSubscriptionKey { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TargetSubscriptionKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TargetSubscriptionKey");
            }
        }
    }
}
