using System.Collections.Generic;
using System.Data;

namespace PaperCave_Models.DTO
{
    public class FetchInput
    {
        public string ConnectionString { get; set; }
        public string SqlCommand { get; set; }
        public CommandType SqlCommandType { get; set; }
        public List<object> Parameters { get; set; }
    }
}
