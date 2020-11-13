using System;
using ChatUI.Models;
using ChatUI.Views.Template.Chat;
using Xamarin.Forms;

namespace ChatUI.Controls
{
    public class ChatMessageDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MessageNew { get; set; }
        public DataTemplate Message { get; set; }

        public ChatMessageDataTemplateSelector()
        {
            this.MessageNew = new DataTemplate(typeof(MessageNewTemplate));
            this.Message = new DataTemplate(typeof(MessageTemplate));
        }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {
                var data = item as ChatUserModel;
                if (data == null)
                    return null;
                if (data.MessageNew)
                    //MENSAJE NUEVO
                    return MessageNew;
                else
                    //MENSAJE VIEJO
                    return Message;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
