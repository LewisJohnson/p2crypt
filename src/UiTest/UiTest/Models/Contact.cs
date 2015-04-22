namespace UiTest.Models
{

	public class Contact
	{

	    public Contact(string userName)
	    {
	        UserName = userName;
	    }


	    public override string ToString()
	    {
	        return UserName;
	    }

	    #region Properties
		public string UserName { get; set; }

	    #endregion Properties
	}
}