// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRIS.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Dataset
    /// </summary>
    public partial class Dataset : Entity
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
        /// <param name="id">The identifier of this entity</param>
        /// <param name="dataImportKind">The kind of the dataset (e.g. acoustic
        /// data, language data ...). Possible values include: 'Language',
        /// 'Acoustic', 'Pronunciation', 'CustomVoice',
        /// 'LanguageGeneration'</param>
        /// <param name="name">The name of the object</param>
        /// <param name="locale">The locale of the contained data</param>
        /// <param name="createdDateTime">The time-stamp when the object was
        /// created</param>
        /// <param name="lastActionDateTime">The time-stamp when the current
        /// status was entered</param>
        /// <param name="status">The status of the object. Possible values
        /// include: 'NotStarted', 'Running', 'Succeeded', 'Failed'</param>
        /// <param name="description">The description of the object</param>
        /// <param name="properties">The custom properties of this
        /// entity</param>
        public Dataset(System.Guid id, string dataImportKind, string name, string locale, System.DateTime createdDateTime, System.DateTime lastActionDateTime, string status, string description = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>))
        {
            Id = id;
            DataImportKind = dataImportKind;
            Name = name;
            Description = description;
            Properties = properties;
            Locale = locale;
            CreatedDateTime = createdDateTime;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

                /// <summary>
        /// Gets or sets the kind of the dataset (e.g. acoustic data, language
        /// data ...). Possible values include: 'Language', 'Acoustic',
        /// 'Pronunciation', 'CustomVoice', 'LanguageGeneration'
        /// </summary>
        [JsonProperty(PropertyName = "dataImportKind")]
        public string DataImportKind { get; set; }

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
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Locale == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Locale");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
