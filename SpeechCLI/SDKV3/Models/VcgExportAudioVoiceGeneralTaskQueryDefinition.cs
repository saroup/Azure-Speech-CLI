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
    /// VcgExportAudioVoiceGeneralTaskQueryDefinition
    /// </summary>
    public partial class VcgExportAudioVoiceGeneralTaskQueryDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// VcgExportAudioVoiceGeneralTaskQueryDefinition class.
        /// </summary>
        public VcgExportAudioVoiceGeneralTaskQueryDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// VcgExportAudioVoiceGeneralTaskQueryDefinition class.
        /// </summary>
        public VcgExportAudioVoiceGeneralTaskQueryDefinition(QueryConditionDefinition queryCondition = default(QueryConditionDefinition))
        {
            QueryCondition = queryCondition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryCondition")]
        public QueryConditionDefinition QueryCondition { get; set; }

    }
}