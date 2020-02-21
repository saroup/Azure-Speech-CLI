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
    /// DownloadVcgTuneDefinitionV3
    /// </summary>
    public partial class DownloadVcgTuneDefinitionV3
    {
        /// <summary>
        /// Initializes a new instance of the DownloadVcgTuneDefinitionV3
        /// class.
        /// </summary>
        public DownloadVcgTuneDefinitionV3()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DownloadVcgTuneDefinitionV3
        /// class.
        /// </summary>
        /// <param name="downloadTypes">The donwload type, use OR logic to
        /// choose multiple types. For example (PlainText | SSML | Audio) = 7.
        /// Possible values include: 'None', 'PlainText', 'Ssml',
        /// 'Audio'</param>
        /// <param name="ttsAudioFormat">The audio format type, only used when
        /// DownloadType contains Audio</param>
        public DownloadVcgTuneDefinitionV3(string ssml, string downloadTypes, System.Guid? ssmlTaskFileId = default(System.Guid?), string ttsAudioFormat = default(string))
        {
            SsmlTaskFileId = ssmlTaskFileId;
            Ssml = ssml;
            DownloadTypes = downloadTypes;
            TtsAudioFormat = ttsAudioFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssmlTaskFileId")]
        public System.Guid? SsmlTaskFileId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssml")]
        public string Ssml { get; set; }

        /// <summary>
        /// Gets or sets the donwload type, use OR logic to choose multiple
        /// types. For example (PlainText | SSML | Audio) = 7. Possible values
        /// include: 'None', 'PlainText', 'Ssml', 'Audio'
        /// </summary>
        [JsonProperty(PropertyName = "downloadTypes")]
        public string DownloadTypes { get; set; }

        /// <summary>
        /// Gets or sets the audio format type, only used when DownloadType
        /// contains Audio
        /// </summary>
        [JsonProperty(PropertyName = "ttsAudioFormat")]
        public string TtsAudioFormat { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Ssml == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ssml");
            }
            if (DownloadTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DownloadTypes");
            }
        }
    }
}