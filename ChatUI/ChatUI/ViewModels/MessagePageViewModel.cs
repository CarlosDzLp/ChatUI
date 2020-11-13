using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using ChatUI.Models;
using ChatUI.ViewModels.Base;
using Xamarin.Forms;

namespace ChatUI.ViewModels
{
    public class MessagePageViewModel : BindableBase
    {
        #region Properties
        public ChatUserModel Chat { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public ObservableCollection<ChatMessageModel> ListMessage { get; set; } = new ObservableCollection<ChatMessageModel>();
        #endregion

        #region Constructor
        public MessagePageViewModel(ChatUserModel chatUser)
        {
            Chat = chatUser;
            Title = Chat.Name;
            LoadMessage();
            SendMessageCommand = new Command(SendMessageCommandExecuted);
        }
        #endregion

        #region Command
        public ICommand SendMessageCommand { get; set; }
        #endregion

        #region CommandExecuted
        private void SendMessageCommandExecuted()
        {
            try
            {
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = false,
                    Message = Message,
                    Date = DateTime.Now.ToString("t")
                });
                Message = string.Empty;
            }
            catch(Exception ex)
            {

            }
        }
        #endregion

        #region Methods
        private void LoadMessage()
        {
            try
            {
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = false,
                    Message = "Hello!!",
                    Date = DateTime.Now.ToString("t")
                });
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = true,
                    Message = "Lorem ipsum Lorem ipsum Lorem ipsum",
                    Date = DateTime.Now.ToString("t")
                });
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = true,
                    Message = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    Date = DateTime.Now.ToString("t")
                });
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = false,
                    Message = "Lorem ipsum",
                    Date = DateTime.Now.ToString("t")
                });
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = false,
                    Message = "Lorem ipsum",
                    Date = DateTime.Now.ToString("t")
                });
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = false,
                    Message = "Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum Lorem ipsum",
                    Date = DateTime.Now.ToString("t")
                });
                ListMessage.Add(new ChatMessageModel
                {
                    IncommingMessage = true,
                    Message = "Lorem ipsum Lorem ipsum Lorem ipsum",
                    Date = DateTime.Now.ToString("t")
                });
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
    }
}
