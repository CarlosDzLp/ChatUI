using System;
using System.Collections.Generic;
using ChatUI.Models;
using ChatUI.ViewModels;
using Xamarin.Forms;

namespace ChatUI.Views
{
    public partial class ChatPage : ContentPage
    {
        ChatPageViewModel chat = null;
        public ChatPage()
        {
            InitializeComponent();
            this.BindingContext = chat = new ChatPageViewModel();
        }

        void CollectionView_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            try
            {
                if(e.CurrentSelection.Count >0)
                {
                    var currentItem = e.CurrentSelection[0] as ChatUserModel;
                    if(currentItem != null)
                    {
                        ((CollectionView)sender).SelectedItem = null;
                        chat.SelectedItemChat(currentItem);                      
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
