using System;
namespace ChatUI.Models
{
    public class ChatMessageModel
    {
        public bool IncommingMessage { get; set; }
        public string Message { get; set; }
        public string Date { get; set; }
    }
}
