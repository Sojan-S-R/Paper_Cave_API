using System;
using System.Data.SqlClient;
using PaperCave_Models.DTO;

namespace PaperCave_Library.AccessLibrary
{
    static class DatabaseAccess
    {
        internal static object FetchData(FetchInput input)
        {
            FetchOutput output = new FetchOutput() { OutputObject = null};
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
                        SqlDataReader rdr = cmd.ExecuteReader();
                        output.OutputObject = rdr;
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
