using System.Collections.Generic;

namespace PaperCave_Models.Objects
{
    class AuthorModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public List<BookModel> ListofWorks { get; set; }
    }
}
