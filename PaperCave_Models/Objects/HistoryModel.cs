using PaperCave_Models.People;
using System.Collections.Generic;

namespace PaperCave_Models.Objects
{
    public class HistoryModel
    {
        public List<SingleTransaction> CustomerHistory{ get; set; }
    }

    public class SingleTransaction 
    {
        public string TransactionId { get; set; }
        public BookModel BookBought { get; set; }
        public AddressModel AddressDelivered { get; set; }
    }
}
