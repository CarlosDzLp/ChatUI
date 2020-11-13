using System;
namespace ChatUI.Models
{
    public class ChatUserModel : UserModel
    {
        public string Date { get; set; }
        public bool MessageNew { get; set; }
        public string Message { get; set; }
    }
}
