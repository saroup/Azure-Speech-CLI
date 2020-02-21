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
    /// Defines headers for CreateHook operation.
    /// </summary>
    public partial class CreateHookHeaders
    {
        /// <summary>
        /// Initializes a new instance of the CreateHookHeaders class.
        /// </summary>
        public CreateHookHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateHookHeaders class.
        /// </summary>
        /// <param name="location">The location of the created
        /// resource.</param>
        /// <param name="xRateLimitLimit">The limit of requests for the
        /// resource.</param>
        /// <param name="xRateLimitRemaining">The remaining number of requests
        /// until the rate limit is reached.</param>
        /// <param name="xRateLimitReset">The timestamp when the rate limit
        /// will be reset formatted as ISO 8601 combined date and time in
        /// UTC.</param>
        /// <param name="retryAfter">The minimum number of seconds to wait
        /// before not getting this response anymore.</param>
        public CreateHookHeaders(string location = default(string), int? xRateLimitLimit = default(int?), int? xRateLimitRemaining = default(int?), string xRateLimitReset = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            XRateLimitLimit = xRateLimitLimit;
            XRateLimitRemaining = xRateLimitRemaining;
            XRateLimitReset = xRateLimitReset;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the created resource.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the limit of requests for the resource.
        /// </summary>
        [JsonProperty(PropertyName = "X-RateLimit-Limit")]
        public int? XRateLimitLimit { get; set; }

        /// <summary>
        /// Gets or sets the remaining number of requests until the rate limit
        /// is reached.
        /// </summary>
        [JsonProperty(PropertyName = "X-RateLimit-Remaining")]
        public int? XRateLimitRemaining { get; set; }

        /// <summary>
        /// Gets or sets the timestamp when the rate limit will be reset
        /// formatted as ISO 8601 combined date and time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "X-RateLimit-Reset")]
        public string XRateLimitReset { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of seconds to wait before not
        /// getting this response anymore.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
