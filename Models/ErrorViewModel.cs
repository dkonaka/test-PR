namespace AspNetCoreApp.Models
{
    /// <summary>
    /// ErrorViewModel represents the data structure used for displaying error information
    /// This model is used by the Error view to show relevant error details to the user
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Gets or sets the unique identifier for the HTTP request that caused the error
        /// This can be used for troubleshooting and correlating logs with specific errors
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Determines whether to display the RequestId to the user
        /// Only shows the RequestId if it has a value (not null or empty)
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}