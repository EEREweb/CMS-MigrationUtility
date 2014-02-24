using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CMS_Migration_Utility
{
    class DBLookup
    {
        public List<string> PerformDBLookup(string lookupText)
        {
            List<string> listNodes = null;

            listNodes = GetNodeMatches(lookupText);

            return listNodes;
        }

        private List<string> GetNodeMatches(string lookupText)
        {
            List<string> foundNodes = new List<string>();

            string sConn = ConfigurationManager.ConnectionStrings["EEREDB"].ToString();
            sConn += System.Text.Encoding.UTF8.GetString(System.Convert.FromBase64String(ConfigurationManager.AppSettings["word"].ToString()));

            using (SqlConnection conn = new SqlConnection(sConn))
            {
                conn.Open();
                using (SqlDataReader reader = new SqlCommand("SELECT DrupalNode FROM dbo.NodeLookup WHERE WebURL LIKE '%" + lookupText + "%' ", conn).ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            foundNodes.Add(reader.GetString(0));
                        }
                    }
                }
                conn.Close();
            }

            return foundNodes;
        }
    }
}
