using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using PaperCave_Models.DTO;
using PaperCave_Models.People;

namespace PaperCave_Library.AccessLibrary
{
    static class DatabaseAccess
    {
        internal static List<CustomerModel> ReturnMappedCustomerData(FetchInput input)
        {
            List<CustomerModel> CustomerData = new List<CustomerModel>();
            try
            {
                DataSet data = FetchData(input).Data;
                if (data.Tables[0].Columns.Count > 0)
                {
                    for (int i = 0; i < data.Tables[0].Rows.Count; i++ )
                    {
                        CustomerData.Add(new CustomerModel() 
                        {
                            
                        });
                    }
                }
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.ToString());
            }
            return CustomerData;
        }

        internal static FetchOutput FetchData(FetchInput input)
        {
            FetchOutput output = new FetchOutput() { Data = null};
            try
            {
                using (SqlConnection conn = new SqlConnection(input.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(input.SqlCommand, conn)) 
                    {
                        cmd.CommandType = input.SqlCommandType;
                        foreach (string p in input.Parameters)
                        {
                            cmd.Parameters.Add(p);
                        }
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet data = new DataSet();
                        da.Fill(data);
                        output.Data = data;
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                output.ErrorMessage = ex.ToString();
            }
            return output;
        }
    }
}
