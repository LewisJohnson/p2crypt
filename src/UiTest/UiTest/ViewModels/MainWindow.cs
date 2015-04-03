using System.Collections.ObjectModel;
using UiTest.Models;

namespace UiTest.ViewModels
{
    public class MainWindow
    {
        private ObservableCollection<Contact> contactsCollection;

        public MainWindow()
        {
            this.ContactsCollection = new ObservableCollection<Contact>
            {
                new Contact("Test Contact 1"),
                new Contact("Test Contact 2"),
                new Contact("Test Contact 3"),
                new Contact("Test Contact 4"),
                new Contact("Test Contact 5"),
                new Contact("Test Contact 6"),
                new Contact("Test Contact 7"),
                new Contact("Test Contact 8"),
                new Contact("Test Contact 9"),
                new Contact("Test Contact 10")

            };

        }

        public ObservableCollection<Contact> ContactsCollection
        {
            get { return this.contactsCollection; }
            set
            {
                if (Equals(value, this.contactsCollection)) return;
                this.contactsCollection = value;
            }
        }

    }
}