using System;
namespace TP_bot_discord
{
	public class PostArgs : EventArgs
	{
        public DateTime DateTimeOfPosting { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }

        public PostArgs(User Author, string Content)
        {
            DateTimeOfPosting = DateTime.Now;
            this.Author = Author;
            this.Content = Content;
        }
    }
}