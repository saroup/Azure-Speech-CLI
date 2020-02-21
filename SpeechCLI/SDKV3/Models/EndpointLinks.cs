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
    /// EndpointLinks
    /// </summary>
    public partial class EndpointLinks
    {
        /// <summary>
        /// Initializes a new instance of the EndpointLinks class.
        /// </summary>
        public EndpointLinks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EndpointLinks class.
        /// </summary>
        public EndpointLinks(string httpRestInteractive = default(string), string httpRestConversation = default(string), string httpRestDictation = default(string), string clientWebSocket = default(string), string clientWebSocketContinuous = default(string), string serviceWebSocket = default(string), string serviceWebSocketContinuous = default(string), string universalWebSocketInteractive = default(string), string universalWebSocketConversation = default(string), string universalWebSocketDictation = default(string))
        {
            HttpRestInteractive = httpRestInteractive;
            HttpRestConversation = httpRestConversation;
            HttpRestDictation = httpRestDictation;
            ClientWebSocket = clientWebSocket;
            ClientWebSocketContinuous = clientWebSocketContinuous;
            ServiceWebSocket = serviceWebSocket;
            ServiceWebSocketContinuous = serviceWebSocketContinuous;
            UniversalWebSocketInteractive = universalWebSocketInteractive;
            UniversalWebSocketConversation = universalWebSocketConversation;
            UniversalWebSocketDictation = universalWebSocketDictation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpRestInteractive")]
        public string HttpRestInteractive { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpRestConversation")]
        public string HttpRestConversation { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "httpRestDictation")]
        public string HttpRestDictation { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientWebSocket")]
        public string ClientWebSocket { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "clientWebSocketContinuous")]
        public string ClientWebSocketContinuous { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceWebSocket")]
        public string ServiceWebSocket { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceWebSocketContinuous")]
        public string ServiceWebSocketContinuous { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "universalWebSocketInteractive")]
        public string UniversalWebSocketInteractive { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "universalWebSocketConversation")]
        public string UniversalWebSocketConversation { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "universalWebSocketDictation")]
        public string UniversalWebSocketDictation { get; private set; }

    }
}
