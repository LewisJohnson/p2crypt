using System;

namespace UiTest.Models
{
	public class Contact
	{
	    public Contact(string userName)
	    {
	        this.UserName = userName;
	    }

	    public override string ToString()
	    {
	        return this.UserName;
	    }

	    #region Properties

		public string UserName { get; set; }

	    #endregion Properties
	}
}