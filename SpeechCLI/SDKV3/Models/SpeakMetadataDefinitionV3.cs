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
    /// SpeakMetadataDefinitionV3
    /// </summary>
    public partial class SpeakMetadataDefinitionV3
    {
        /// <summary>
        /// Initializes a new instance of the SpeakMetadataDefinitionV3 class.
        /// </summary>
        public SpeakMetadataDefinitionV3()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SpeakMetadataDefinitionV3 class.
        /// </summary>
        /// <param name="ttsMetadataTypes">Possible values include: 'None',
        /// 'Duration', 'F0', 'PronConfScore', 'Pron', 'DurationAndF0'</param>
        /// <param name="pronPhoneSetType">Possible values include: 'None',
        /// 'Sapi', 'Ups', 'Ipa', 'Tts', 'All'</param>
        public SpeakMetadataDefinitionV3(string ttsMetadataTypes, TuneDefinitionV3 tuneDefinition, string pronPhoneSetType = default(string), int? metadataOffsetInPlainText = default(int?), int? metadataLengthInPlainText = default(int?))
        {
            TtsMetadataTypes = ttsMetadataTypes;
            TuneDefinition = tuneDefinition;
            PronPhoneSetType = pronPhoneSetType;
            MetadataOffsetInPlainText = metadataOffsetInPlainText;
            MetadataLengthInPlainText = metadataLengthInPlainText;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Duration', 'F0',
        /// 'PronConfScore', 'Pron', 'DurationAndF0'
        /// </summary>
        [JsonProperty(PropertyName = "ttsMetadataTypes")]
        public string TtsMetadataTypes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tuneDefinition")]
        public TuneDefinitionV3 TuneDefinition { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Sapi', 'Ups', 'Ipa',
        /// 'Tts', 'All'
        /// </summary>
        [JsonProperty(PropertyName = "pronPhoneSetType")]
        public string PronPhoneSetType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadataOffsetInPlainText")]
        public int? MetadataOffsetInPlainText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadataLengthInPlainText")]
        public int? MetadataLengthInPlainText { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TtsMetadataTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TtsMetadataTypes");
            }
            if (TuneDefinition == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TuneDefinition");
            }
            if (TuneDefinition != null)
            {
                TuneDefinition.Validate();
            }
        }
    }
}
