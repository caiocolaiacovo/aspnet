using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class Post
    {
        public Post()
        {
            this.Comments = new List<Comment>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Author Author { get; set; }
    }
}