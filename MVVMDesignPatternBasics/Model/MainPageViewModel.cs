using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDesignPatternBasics.Model
{
    public class MainPageViewModel : BindableBase<Book>
    {
        private Book _book;

        public Book Book
        { 
            get
            {
                return _book;
            } 
            set
            {
                SetProperty(ref _book, value);
            } 
        }
        
        public MainPageViewModel()
        {
            Book = new Book()
            {
                Title = "Harry Potter",
                Author = "J. K. Rowling",
                Category = "Young-adult fiction",
                Language = "English"
            };
        }
    }
}
