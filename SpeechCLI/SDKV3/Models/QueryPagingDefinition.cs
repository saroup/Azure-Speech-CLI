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
    /// QueryPagingDefinition
    /// </summary>
    public partial class QueryPagingDefinition
    {
        /// <summary>
        /// Initializes a new instance of the QueryPagingDefinition class.
        /// </summary>
        public QueryPagingDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryPagingDefinition class.
        /// </summary>
        public QueryPagingDefinition(int? countPerPage = default(int?), int? pageIndex = default(int?))
        {
            CountPerPage = countPerPage;
            PageIndex = pageIndex;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countPerPage")]
        public int? CountPerPage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "pageIndex")]
        public int? PageIndex { get; set; }

    }
}
