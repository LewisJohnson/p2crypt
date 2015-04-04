namespace UiTest.Models
{
    /// <summary>
    /// User Message Model. This class can be instanced to make a new message.
    /// </summary>
	public class Message
	{
		#region Properties

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        /// <value>
        /// The content.
        /// </value>
		public string Content { get; set; }

        /// <summary>
        /// Gets or sets the timestamp.
        /// </summary>
        /// <value>
        /// The timestamp.
        /// </value>
		public string Timestamp { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
		public string UserName { get; set; }

		#endregion Properties
	}
}