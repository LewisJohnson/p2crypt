using System.Collections.ObjectModel;
using UiTest.Models;

namespace UiTest.ViewModels
{
    public class MainWindow
    {
        private ObservableCollection<Contact> _contactsCollection;

        public MainWindow()
        {
            ContactsCollection = new ObservableCollection<Contact>
            {
                new Contact("Slackbot"),
                new Contact("Lewisj489"),
                new Contact("Scoggs"),
                new Contact("Flo"),
                new Contact("Dartman5000"),
                new Contact("Chargino"),
                new Contact("Kyles"),
                new Contact("Gixen"),
                new Contact("Marcstan"),
                new Contact("Muffinman007"),
                new Contact("R01ne"),
                new Contact("Tarik149"),
                new Contact("Websly"),
                new Contact("Test contact"),
                new Contact("Gabe Newell"),
                new Contact("Dr.Plonickidonk"),
                new Contact("Nathan Rohnson"),
                new Contact("Spongebob SquarePants"),
                new Contact("Patrick Starfish"),
                new Contact("Taylor Swift"),
                new Contact("Psy - Gangnam Style")
            };
        }

        public ObservableCollection<Contact> ContactsCollection
        {
            get { return _contactsCollection; }
            set
            {
                if (Equals(value, _contactsCollection)) return;
                _contactsCollection = value;
            }
        }
    }
}