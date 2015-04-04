namespace UiTest.Models
{
    /// <summary>
    /// User Message Model. This class can be instanced to make a new Contact.
    /// </summary>
	public class Contact
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
	    public Contact(string userName)
	    {
	        this.UserName = userName;
	    }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
	    public override string ToString()
	    {
	        return this.UserName;
	    }

	    #region Properties

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