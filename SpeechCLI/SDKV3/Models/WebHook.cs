// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Speech.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// WebHook
    /// </summary>
    public partial class WebHook
    {
        /// <summary>
        /// Initializes a new instance of the WebHook class.
        /// </summary>
        public WebHook()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebHook class.
        /// </summary>
        /// <param name="displayName">The display name of the object</param>
        /// <param name="configuration">The configuration of the web hook
        /// registration.
        ///
        /// If the property secret is omitted or contains an empty string in a
        /// POST or PATCH request,
        /// no signature hash will be calculated.
        ///
        /// When retrieving web hook registration information from the service,
        /// the secret is always omitted</param>
        /// <param name="active">A value indicating whether callbacks to the
        /// registered URL are made or not</param>
        /// <param name="events">A value indicating the webhook event
        /// kinds</param>
        /// <param name="self">The location of this entity</param>
        /// <param name="description">The description of the object</param>
        /// <param name="properties">The custom properties of this
        /// entity</param>
        /// <param name="createdDateTime">The time-stamp when the object was
        /// created</param>
        /// <param name="links">Related links to this webhook entity</param>
        /// <param name="failureReason">The failure reason, if the hook is in
        /// state "Failed"</param>
        /// <param name="apiVersion">The API version the web hook was created
        /// in. This defines the shape of the payload in the callbacks.
        /// If the payload type is not supported anymore, because the shape
        /// changed and the API version using it is removed (after
        /// deprecation),
        /// the web hook will be disabled</param>
        /// <param name="lastActionDateTime">The time-stamp when the current
        /// status was entered</param>
        /// <param name="status">The status of the object. Possible values
        /// include: 'NotStarted', 'Running', 'Succeeded', 'Failed'</param>
        public WebHook(string displayName, WebHookConfiguration configuration, bool active, IList<string> events, string self = default(string), string description = default(string), IDictionary<string, string> properties = default(IDictionary<string, string>), System.DateTime? createdDateTime = default(System.DateTime?), WebHookLinks links = default(WebHookLinks), string failureReason = default(string), string apiVersion = default(string), System.DateTime? lastActionDateTime = default(System.DateTime?), string status = default(string))
        {
            Self = self;
            DisplayName = displayName;
            Description = description;
            Configuration = configuration;
            Active = active;
            Events = events;
            Properties = properties;
            CreatedDateTime = createdDateTime;
            Links = links;
            FailureReason = failureReason;
            ApiVersion = apiVersion;
            LastActionDateTime = lastActionDateTime;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the location of this entity
        /// </summary>
        [JsonProperty(PropertyName = "self")]
        public string Self { get; private set; }

        /// <summary>
        /// Gets or sets the display name of the object
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the description of the object
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the configuration of the web hook registration.
        ///
        /// If the property secret is omitted or contains an empty string in a
        /// POST or PATCH request,
        /// no signature hash will be calculated.
        ///
        /// When retrieving web hook registration information from the service,
        /// the secret is always omitted
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public WebHookConfiguration Configuration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether callbacks to the registered
        /// URL are made or not
        /// </summary>
        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating the webhook event kinds
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<string> Events { get; set; }

        /// <summary>
        /// Gets or sets the custom properties of this entity
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IDictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Gets the time-stamp when the object was created
        /// </summary>
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; private set; }

        /// <summary>
        /// Gets related links to this webhook entity
        /// </summary>
        [JsonProperty(PropertyName = "links")]
        public WebHookLinks Links { get; private set; }

        /// <summary>
        /// Gets the failure reason, if the hook is in state "Failed"
        /// </summary>
        [JsonProperty(PropertyName = "failureReason")]
        public string FailureReason { get; private set; }

        /// <summary>
        /// Gets the API version the web hook was created in. This defines the
        /// shape of the payload in the callbacks.
        /// If the payload type is not supported anymore, because the shape
        /// changed and the API version using it is removed (after
        /// deprecation),
        /// the web hook will be disabled
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; private set; }

        /// <summary>
        /// Gets the time-stamp when the current status was entered
        /// </summary>
        [JsonProperty(PropertyName = "lastActionDateTime")]
        public System.DateTime? LastActionDateTime { get; private set; }

        /// <summary>
        /// Gets the status of the object. Possible values include:
        /// 'NotStarted', 'Running', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (Configuration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Configuration");
            }
            if (Events == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Events");
            }
            if (Configuration != null)
            {
                Configuration.Validate();
            }
        }
    }
}