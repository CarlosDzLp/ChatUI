using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ChatUI.Models;
using ChatUI.ViewModels.Base;

namespace ChatUI.ViewModels
{
    public class ChatPageViewModel : BindableBase
    {
        #region Properties
        public ObservableCollection<UserModel> ListUser { get; set; }

        public ObservableCollection<ChatUserModel> ListChat { get; set; } = new ObservableCollection<ChatUserModel>();
        #endregion

        #region Constructor
        public ChatPageViewModel()
        {
            _ = LoadUser();
            LoadChat();
        }
        #endregion

        #region Methods
        private async Task LoadUser()
        {
            try
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
                ListUser = new ObservableCollection<UserModel>();
                ListUser.Clear();
                ListUser.Add(new UserModel()
                {
                    Name = "Maria",
                    Image = "https://qodebrisbane.com/wp-content/uploads/2019/07/This-is-not-a-person-2-1.jpeg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Juan",
                    Image = "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/419665d2-74b7-49d4-b3c8-3aea253f966f.jpg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Norma",
                    Image = "https://engineering.unl.edu/images/staff/Kayla_Person-small.jpg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Pedro",
                    Image = "https://newcastlebeach.org/images/male-images.jpg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Maria",
                    Image = "https://qodebrisbane.com/wp-content/uploads/2019/07/This-is-not-a-person-2-1.jpeg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Juan",
                    Image = "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/419665d2-74b7-49d4-b3c8-3aea253f966f.jpg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Pedro",
                    Image = "https://newcastlebeach.org/images/male-images.jpg"
                });
                ListUser.Add(new UserModel()
                {
                    Name = "Pedro",
                    Image = "https://newcastlebeach.org/images/male-images.jpg"
                });
            }
            catch(Exception ex)
            {

            }
        }

        private void LoadChat()
        {
            try
            {
                ListChat.Clear();
                ListChat.Add(new ChatUserModel()
                {
                    Date="Fri",
                    Name = "Maria",
                    Message= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    Image = "https://qodebrisbane.com/wp-content/uploads/2019/07/This-is-not-a-person-2-1.jpeg"
                });
                ListChat.Add(new ChatUserModel()
                {
                    Date = "Sat",
                    Name = "Juan",
                    Message = "Lorem Ipsum has been the industry's",
                    Image = "https://d25rq8gxcq0p71.cloudfront.net/dictionary-images/324/419665d2-74b7-49d4-b3c8-3aea253f966f.jpg"
                });
                ListChat.Add(new ChatUserModel()
                {
                    Date = "17:45",
                    Name = "Norma",
                    Message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    MessageNew = true,
                    Image = "https://engineering.unl.edu/images/staff/Kayla_Person-small.jpg"
                });
                ListChat.Add(new ChatUserModel()
                {
                    Date = "17:45",
                    Name = "Norma",
                    Message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    MessageNew = true,
                    Image = "https://engineering.unl.edu/images/staff/Kayla_Person-small.jpg"
                });
                ListChat.Add(new ChatUserModel()
                {
                    Date = "Fri",
                    Name = "Maria",
                    Message = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    Image = "https://qodebrisbane.com/wp-content/uploads/2019/07/This-is-not-a-person-2-1.jpeg"
                });
                ListChat.Add(new ChatUserModel()
                {
                    Date = "12:43",
                    MessageNew = true,
                    Name = "Pedro",
                    Message = "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                    Image = "https://newcastlebeach.org/images/male-images.jpg"
                });
            }
            catch(Exception ex)
            {

            }
        }

        public void SelectedItemChat(ChatUserModel chatUser)
        {
            try
            {
                if (chatUser != null)
                {
                    App.Current.MainPage.Navigation.PushAsync(new Views.MessagePage(chatUser));
                }
            }
            catch(Exception ex)
            {

            }
        }
        #endregion
    }
}
