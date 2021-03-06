// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace CRIS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for PostMoveToSubscription operation.
    /// </summary>
    public partial class PostMoveToSubscriptionHeaders
    {
        /// <summary>
        /// Initializes a new instance of the PostMoveToSubscriptionHeaders
        /// class.
        /// </summary>
        public PostMoveToSubscriptionHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PostMoveToSubscriptionHeaders
        /// class.
        /// </summary>
        /// <param name="location">The URI of the operation.</param>
        /// <param name="operationLocation">The URI of the operation.</param>
        /// <param name="retryAfter">The minimum number of seconds to wait
        /// before accessing the resource created in this operation.</param>
        /// <param name="xRateLimitLimit">The limit of requests for the
        /// resource.</param>
        /// <param name="xRateLimitRemaining">The remaining number of requests
        /// until the rate limit is reached.</param>
        /// <param name="xRateLimitReset">The timestamp when the rate limit
        /// will be resetted formatted as ISO 8601 combined date and time in
        /// UTC.</param>
        public PostMoveToSubscriptionHeaders(string location = default(string), string operationLocation = default(string), int? retryAfter = default(int?), int? xRateLimitLimit = default(int?), int? xRateLimitRemaining = default(int?), string xRateLimitReset = default(string))
        {
            Location = location;
            OperationLocation = operationLocation;
            RetryAfter = retryAfter;
            XRateLimitLimit = xRateLimitLimit;
            XRateLimitRemaining = xRateLimitRemaining;
            XRateLimitReset = xRateLimitReset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URI of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the URI of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "Operation-Location")]
        public string OperationLocation { get; set; }

        /// <summary>
        /// Gets or sets the minimum number of seconds to wait before accessing
        /// the resource created in this operation.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

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
        /// Gets or sets the timestamp when the rate limit will be resetted
        /// formatted as ISO 8601 combined date and time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "X-RateLimit-Reset")]
        public string XRateLimitReset { get; set; }

    }
}
