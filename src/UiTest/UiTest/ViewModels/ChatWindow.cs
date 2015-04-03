using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using UiTest.Models;
using UiTest.Properties;

namespace UiTest.ViewModels
{

    //TODO: Implement button design change. If textbox focused, Make button visible, or change button style.


    public sealed class ChatWindow : INotifyPropertyChanged
	{
		#region Fields

		private ObservableCollection<Message> _messages;
		private string _newMessage;
		private ICommand _sendCommand;



		#endregion Fields

		#region Constructors

		public ChatWindow()
		{
			Messages = new ObservableCollection<Message>
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

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = this.PropertyChanged;
		    if (handler != null)
		    {
		        handler(this, new PropertyChangedEventArgs(propertyName));


		    }
		}

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