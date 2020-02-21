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
    /// Dataset
    /// </summary>
    public partial class Dataset
    {
        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        public Dataset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Dataset class.
        /// </summary>
        /// <param name="dataImportKind">The kind of the dataset (e.g.,
        /// acoustic data, language data, ...). Possible values include:
        /// 'Language', 'Acoustic', 'Pronunciation', 'AudioFiles'</param>
        /// <param name="displayName">The display name of the object</param>
        /// <param name="sourceUrl">The URL of the data for the dataset</param>
        /// <param name="locale">The locale of the contained data</param>
        /// <param name="links">The location to get all files of this
        /// entity</param>
        /// <param name="datasetProperties">Additional configuration options
        /// when creating a new dataset and additional metadata provided by the
        /// service</param>
        /// <param name="self">The location of this entity</param>
        /// <param name="description">The description of the object</param>
        /// <param name="project">The project, the dataset is associated
        /// with</param>
        /// <param name="properties">The custom properties of this
        /// entity</param>
        /// <param name="lastActionDateTime">The time-stamp when the current
        /// status was entered</param>
        /// <param name="status">The status of the object. Possible values
        /// include: 'NotStarted', 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="createdDateTime">The time-stamp when the object was
        /// created</param>
        public Dataset(string dataImportKind, string displayName, string sourceUrl, string locale, FileLinks links = default(FileLinks), DatasetProperties datasetProperties = default(DatasetProperties), string self = default(string), string description = default(string), EntityReference project = default(EntityReference), IDictionary<string, string> properties = default(IDictionary<string, string>), System.DateTime? lastActionDateTime = default(System.DateTime?), string status = default(string), System.DateTime? createdDateTime = default(System.DateTime?))
        {
            Links = links;
            DatasetProperties = datasetProperties;
            DataImportKind = dataImportKind;
            Self = self;
            DisplayName = displayName;
            Description = description;
            Project = project;
            SourceUrl = sourceUrl;
            Properties = properties;
            Locale = locale;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            CreatedDateTime = createdDateTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the location to get all files of this entity
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public FileLinks Links { get; private set; }

        /// <summary>
        /// Gets or sets additional configuration options when creating a new
        /// dataset and additional metadata provided by the service
        /// </summary>
        [JsonProperty(PropertyName = "datasetProperties")]
        public DatasetProperties DatasetProperties { get; set; }

        /// <summary>
        /// Gets or sets the kind of the dataset (e.g., acoustic data, language
        /// data, ...). Possible values include: 'Language', 'Acoustic',
        /// 'Pronunciation', 'AudioFiles'
        /// </summary>
        [JsonProperty(PropertyName = "dataImportKind")]
        public string DataImportKind { get; set; }

        /// <summary>
        /// Gets the location of this entity
        /// </summary>
        [JsonProperty(PropertyName = "self")]
        public string Self { get; private set; }

        /// <summary>
        /// Gets or sets the display name of the object
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the object
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the project, the dataset is associated with
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public EntityReference Project { get; set; }

        /// <summary>
        /// Gets or sets the URL of the data for the dataset
        /// </summary>
        [JsonProperty(PropertyName = "sourceUrl")]
        public string SourceUrl { get; set; }

        /// <summary>
        /// Gets or sets the custom properties of this entity
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets or sets the locale of the contained data
        /// </summary>
        [JsonProperty(PropertyName = "locale")]
        public string Locale { get; set; }

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
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DataImportKind == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataImportKind");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (SourceUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SourceUrl");
            }
            if (Locale == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Locale");
            }
            if (Project != null)
            {
                Project.Validate();
            }
        }
    }
}