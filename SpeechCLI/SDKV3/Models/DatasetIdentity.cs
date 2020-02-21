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
    /// DatasetIdentity
    /// </summary>
    public partial class DatasetIdentity
    {
        /// <summary>
        /// Initializes a new instance of the DatasetIdentity class.
        /// </summary>
        public DatasetIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetIdentity class.
        /// </summary>
        /// <param name="id">The identifier of this entity</param>
        public DatasetIdentity(System.Guid id)
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier of this entity
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
