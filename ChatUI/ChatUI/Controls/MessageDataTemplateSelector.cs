using System;
using System.Linq;
using ChatUI.Models;
using ChatUI.Views.Template.Chat;
using ChatUI.Views.Template.ChatMessage;
using Xamarin.Forms;

namespace ChatUI.Controls
{
    public class MessageDataTemplateSelector : DataTemplateSelector
    {
        public MessageDataTemplateSelector()
        {
            this.IncomingMessage = new DataTemplate(typeof(IncomingMessage));
            this.OutgoingMessage = new DataTemplate(typeof(OutgoingMessage));
        }

        public DataTemplate IncomingMessage { get; set; }
        public DataTemplate OutgoingMessage { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            try
            {
                var data = item as ChatMessageModel;
                if(data.IncommingMessage)
                {
                    //MENSAJE ENTRANTE
                    return IncomingMessage;
                }
                {
                    //MENSAGE SALIENTE
                    return OutgoingMessage;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        //protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        //{
        //    var data = item as ChatUserModel;
        //    if (data == null)
        //        return null;
        //    if (data.MessageNew)
        //        //MENSAJE NUEVO
        //        return MessageNew;
        //    else
        //        //MENSAJE VIEJO
        //        return Message;
        //}
    }
}
