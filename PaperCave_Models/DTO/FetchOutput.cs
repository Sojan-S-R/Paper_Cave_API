using System.Data;

namespace PaperCave_Models.DTO
{
    public class FetchOutput
    {
        public DataSet Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}
