using PaperCave_Models.Objects;

namespace PaperCave_Models.People
{
    public class CustomerModel:PeopleModel
    {
        public string CustomerID { get; set; }
        public HistoryModel CustomerHistory { get; set; }
    }
}
