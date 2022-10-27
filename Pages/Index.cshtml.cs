using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace BookStore.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IBookStoreData booksData;
        private readonly ILogger<IndexModel> logger;

        public IEnumerable<Book> Books;

        public IndexModel(IBookStoreData booksData, ILogger<IndexModel> logger)
        {
            this.booksData = booksData;
            this.logger = logger;
        }

        public void OnGet()
        {
            Books = booksData.GetAll();
        }
    }
}