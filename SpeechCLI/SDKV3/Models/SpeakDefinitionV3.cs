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
    /// SpeakDefinitionV3
    /// </summary>
    public partial class SpeakDefinitionV3
    {
        /// <summary>
        /// Initializes a new instance of the SpeakDefinitionV3 class.
        /// </summary>
        public SpeakDefinitionV3()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SpeakDefinitionV3 class.
        /// </summary>
        public SpeakDefinitionV3(string ssml, string ttsAudioFormat, int? offsetInPlainText = default(int?), int? lengthInPlainText = default(int?))
        {
            Ssml = ssml;
            TtsAudioFormat = ttsAudioFormat;
            OffsetInPlainText = offsetInPlainText;
            LengthInPlainText = lengthInPlainText;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssml")]
        public string Ssml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ttsAudioFormat")]
        public string TtsAudioFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "offsetInPlainText")]
        public int? OffsetInPlainText { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lengthInPlainText")]
        public int? LengthInPlainText { get; set; }

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
            if (TtsAudioFormat == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TtsAudioFormat");
            }
        }
    }
}