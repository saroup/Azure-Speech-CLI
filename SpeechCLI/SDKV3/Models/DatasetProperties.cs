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
    /// DatasetProperties
    /// </summary>
    public partial class DatasetProperties
    {
        /// <summary>
        /// Initializes a new instance of the DatasetProperties class.
        /// </summary>
        public DatasetProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetProperties class.
        /// </summary>
        /// <param name="acceptedLineCount">The number of lines accepted for
        /// this data set</param>
        /// <param name="rejectedLineCount">The number of lines rejected for
        /// this data set</param>
        /// <param name="duration">The duration of the acoustic
        /// datasets</param>
        /// <param name="email">The email address to send email notifications
        /// to in case the operation completes.
        /// The value will be removed after successfully sending the
        /// email</param>
        public DatasetProperties(int? acceptedLineCount = default(int?), int? rejectedLineCount = default(int?), string duration = default(string), string email = default(string))
        {
            AcceptedLineCount = acceptedLineCount;
            RejectedLineCount = rejectedLineCount;
            Duration = duration;
            Email = email;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the number of lines accepted for this data set
        /// </summary>
        [JsonProperty(PropertyName = "acceptedLineCount")]
        public int? AcceptedLineCount { get; private set; }

        /// <summary>
        /// Gets the number of lines rejected for this data set
        /// </summary>
        [JsonProperty(PropertyName = "rejectedLineCount")]
        public int? RejectedLineCount { get; private set; }

        /// <summary>
        /// Gets the duration of the acoustic datasets
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; private set; }

        /// <summary>
        /// Gets or sets the email address to send email notifications to in
        /// case the operation completes.
        /// The value will be removed after successfully sending the email
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

    }
}