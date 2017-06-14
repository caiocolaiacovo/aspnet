using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public virtual Person Person { get; set; }
        public virtual Post Post { get; set; }
    }
}