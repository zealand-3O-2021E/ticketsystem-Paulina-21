using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Library
{
    public class Book
    {
        /// <summary>
        /// type string, public
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// type string, public
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Number of pages, type int, public
        /// </summary>
        public int PageNo { get; set; }
        /// <summary>
        ///the ID of the book, type string, public
        /// </summary>
        public string ISBN13 { get; set; }
    }
}
