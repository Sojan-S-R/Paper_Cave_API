using System.Collections.Generic;
using PaperCave_Models.People;
using PaperCave_Mocks;
using PaperCave_Models.DTO;

namespace PaperCave_API.BridgeCode
{
    public class MapData
    {
        public static List<CustomerModel> GetCustomer(string parameter = null)
        {
            FetchInput input = new FetchInput();
            
            if (parameter != null)
                return new List<CustomerModel>() { MockServices.ReturnMappedCustomerData_Mock(parameter) };           
            else
                return MockServices.ReturnMappedCustomerData_Mock();
        }
    }
}
