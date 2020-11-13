using System;
using System.Collections.Generic;
using ChatUI.Models;
using ChatUI.ViewModels;
using Xamarin.Forms;

namespace ChatUI.Views
{
    public partial class MessagePage : ContentPage
    {
        public MessagePage(ChatUserModel chatUser)
        {
            InitializeComponent();
            this.BindingContext = new MessagePageViewModel(chatUser);
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            App.Current.MainPage.Navigation.RemovePage(this);
        }
    }
}
