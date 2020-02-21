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
    /// QueryExportAudioTaskResponse
    /// </summary>
    public partial class QueryExportAudioTaskResponse
    {
        /// <summary>
        /// Initializes a new instance of the QueryExportAudioTaskResponse
        /// class.
        /// </summary>
        public QueryExportAudioTaskResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryExportAudioTaskResponse
        /// class.
        /// </summary>
        /// <param name="id">The identifier of this entity</param>
        /// <param name="name">The name of the object</param>
        /// <param name="module">Possible values include: 'None',
        /// 'VcgExportAudio', 'VcgExportRealTimeAudio'</param>
        /// <param name="state">Possible values include: 'None', 'Waiting',
        /// 'Processing', 'Complete', 'Failed', 'Deleting'</param>
        /// <param name="lastActionDateTime">The time-stamp when the current
        /// status was entered</param>
        /// <param name="status">The status of the object. Possible values
        /// include: 'NotStarted', 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="createdDateTime">The time-stamp when the object was
        /// created</param>
        /// <param name="description">The description of the object</param>
        /// <param name="properties">The custom properties of this
        /// entity</param>
        public QueryExportAudioTaskResponse(System.Guid id, string name, VcgFolder operationFolder = default(VcgFolder), VcgBlobEntityDefinition reportFile = default(VcgBlobEntityDefinition), IList<QueryAudioFileResponse> audioFiles = default(IList<QueryAudioFileResponse>), string module = default(string), string state = default(string), System.DateTime? lastActionDateTime = default(System.DateTime?), string status = default(string), System.DateTime? createdDateTime = default(System.DateTime?), string description = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            OperationFolder = operationFolder;
            ReportFile = reportFile;
            AudioFiles = audioFiles;
            Module = module;
            State = state;
            Id = id;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            CreatedDateTime = createdDateTime;
            Name = name;
            Description = description;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "operationFolder")]
        public VcgFolder OperationFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "reportFile")]
        public VcgBlobEntityDefinition ReportFile { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "audioFiles")]
        public IList<QueryAudioFileResponse> AudioFiles { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'VcgExportAudio',
        /// 'VcgExportRealTimeAudio'
        /// </summary>
        [JsonProperty(PropertyName = "module")]
        public string Module { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Waiting',
        /// 'Processing', 'Complete', 'Failed', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the identifier of this entity
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

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
        /// Gets or sets the name of the object
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the object
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the custom properties of this entity
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (OperationFolder != null)
            {
                OperationFolder.Validate();
            }
            if (ReportFile != null)
            {
                ReportFile.Validate();
            }
            if (AudioFiles != null)
            {
                foreach (var element in AudioFiles)
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
