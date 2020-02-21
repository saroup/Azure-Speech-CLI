// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Speech.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ErrorContent information.
    /// </summary>
    public partial class ErrorContentException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ErrorContent Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ErrorContentException class.
        /// </summary>
        public ErrorContentException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorContentException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ErrorContentException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ErrorContentException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ErrorContentException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}