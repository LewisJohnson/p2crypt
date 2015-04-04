using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;
using UiTest.Models;
using UiTest.Properties;

namespace UiTest.ViewModels
{


    //TODO: Implement button design change. If textbox focused, Make button visible, or change button style.


    /// <summary>
    /// 
    /// </summary>
    public sealed class ChatWindow : INotifyPropertyChanged
    {

        #region Fields

        private ObservableCollection<Message> _messages;
        private string _newMessage;
        private ICommand _sendCommand;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWindow"/> class.
        /// </summary>
        public ChatWindow()
        {


            this.Messages = new ObservableCollection<Message>
			{
				new Message
				{
					Content = "Test from viewmodel",
					Timestamp = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString(),
					UserName = "ViewModel"
				}
			};
        }


        #endregion Constructors

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties


        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        public ObservableCollection<Message> Messages
        {
            get { return _messages; }
            set
            {
                if (Equals(value, _messages)) return;
                _messages = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the new message.
        /// </summary>
        /// <value>
        /// The new message.
        /// </value>
        public string NewMessage
        {
            get { return _newMessage; }
            set
            {
                if (value == _newMessage) return;
                _newMessage = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Gets the send command.
        /// </summary>
        /// <value>
        /// The send command.
        /// </value>
        public ICommand SendCommand
        {
            get
            {
                return _sendCommand ?? (_sendCommand = new RelayCommand<string>(o =>
                {
                    SendMessage(NewMessage);
                    NewMessage = null;
                }, o => !string.IsNullOrEmpty(NewMessage)));
            }
        }

        /// <summary>
        /// Gets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public object UserName
        {
            get
            {
                //TODO: Implement real contact
                return new Contact("Contact").ToString();
            }
        }


        #endregion Properties

        #region Methods

        /// <summary>
        /// Called when [property changed].
        /// </summary>
        /// <param name="propertyName">Name of the property.</param>
        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));


            }
        }

        /// <summary>
        /// Sends the message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <exception cref="System.ArgumentException">message</exception>
        private void SendMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentException("message");
            }

            Messages.Add(new Message
            {
                Content = message,
                Timestamp = DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString(),
                UserName = "You"
            });
        }

        #endregion Methods
    }
}