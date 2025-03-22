using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication.Model
{
    public class Books
    {
        public string ArticleNumber { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string IssueDate { get; set; }
        public string ReturnDate { get; set; }
        public string Status { get; set; }
        public string ReaderName { get; set; }

    }
}
