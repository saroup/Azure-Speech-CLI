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
    /// EndpointData
    /// </summary>
    public partial class EndpointData
    {
        /// <summary>
        /// Initializes a new instance of the EndpointData class.
        /// </summary>
        public EndpointData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointData class.
        /// </summary>
        /// <param name="id">The identifier of this entity</param>
        /// <param name="startDate">The start date of the demplyment data
        /// export</param>
        /// <param name="endDate">The end date of the demplyment data
        /// export</param>
        /// <param name="dataUrl">The resulting data Url for the model
        /// deployment</param>
        /// <param name="lastActionDateTime">The time-stamp when the current
        /// status was entered</param>
        /// <param name="status">The status of the object. Possible values
        /// include: 'NotStarted', 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="createdDateTime">The time-stamp when the object was
        /// created</param>
        public EndpointData(System.Guid id, System.DateTime startDate, System.DateTime endDate, string dataUrl = default(string), System.DateTime? lastActionDateTime = default(System.DateTime?), string status = default(string), System.DateTime? createdDateTime = default(System.DateTime?))
        {
            Id = id;
            DataUrl = dataUrl;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            CreatedDateTime = createdDateTime;
            StartDate = startDate;
            EndDate = endDate;
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
        /// Gets or sets the resulting data Url for the model deployment
        /// </summary>
        [JsonProperty(PropertyName = "dataUrl")]
        public string DataUrl { get; set; }

        /// <summary>
        /// Gets the time-stamp when the current status was entered
        /// </summary>
        [JsonProperty(PropertyName = "lastActionDateTime")]
        public System.DateTime? LastActionDateTime { get; private set; }

        /// <summary>
        /// Gets the status of the object. Possible values include:
        /// 'NotStarted', 'Running', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets the time-stamp when the object was created
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Gets or sets the start date of the demplyment data export
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the demplyment data export
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime EndDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
