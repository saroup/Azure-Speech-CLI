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
    /// UtteranceDefinition
    /// </summary>
    public partial class UtteranceDefinition
    {
        /// <summary>
        /// Initializes a new instance of the UtteranceDefinition class.
        /// </summary>
        public UtteranceDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UtteranceDefinition class.
        /// </summary>
        /// <param name="sessionId">The id of the session (audio file
        /// name)</param>
        /// <param name="isHumanTranscription">A value indicating whether it is
        /// a human transcription</param>
        /// <param name="lexicalForm">The text</param>
        /// <param name="startTimeOffset">The offset from start time</param>
        /// <param name="duration">The duration</param>
        public UtteranceDefinition(System.Guid sessionId, bool isHumanTranscription, string lexicalForm, string startTimeOffset, string duration)
        {
            SessionId = sessionId;
            IsHumanTranscription = isHumanTranscription;
            LexicalForm = lexicalForm;
            StartTimeOffset = startTimeOffset;
            Duration = duration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the session (audio file name)
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public System.Guid SessionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is a human transcription
        /// </summary>
        [JsonProperty(PropertyName = "isHumanTranscription")]
        public bool IsHumanTranscription { get; set; }

        /// <summary>
        /// Gets or sets the text
        /// </summary>
        [JsonProperty(PropertyName = "lexicalForm")]
        public string LexicalForm { get; set; }

        /// <summary>
        /// Gets or sets the offset from start time
        /// </summary>
        [JsonProperty(PropertyName = "startTimeOffset")]
        public string StartTimeOffset { get; set; }

        /// <summary>
        /// Gets or sets the duration
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public string Duration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LexicalForm == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LexicalForm");
            }
            if (StartTimeOffset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTimeOffset");
            }
            if (Duration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Duration");
            }
        }
    }
}