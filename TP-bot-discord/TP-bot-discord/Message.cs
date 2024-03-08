using System;
namespace TP_bot_discord
{
	public class Message
	{
		public DateTime DateTimeOfPosting { get; set; }
		public string Content { get; set; }
		public User Author { get; set; }
		public event EventHandler<PostArgs> OnPost;

		public Message(User Author, string Content)
		{
			DateTimeOfPosting = DateTime.Now;
			this.Author = Author;
			this.Content = Content;
			Author.Messages.Add(this);
		}

        public Message(string Content)
        {
            DateTimeOfPosting = DateTime.Now;
            this.Content = Content;
        }

        public void Post(Channel channel)
		{
            PostArgs postArgs = new PostArgs(Author, Content);
			channel.History.Add(this);
			if (Content.Contains("welcome") || Content.Contains("Welcome"))
			{
				OnPost?.Invoke(this, postArgs);
			}
			
        }
	}
}