using GlobalJobSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GlobalJobSearch.Repositories
{
    public class JobDescriptionRepository
    {
        public static bool getSQLConnection(string query)
        {
            var connectionString = "Data Source=dbr.fast.sheridanc.on.ca;Initial Catalog=section8;user id = s8u26; password = Sher1dan";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                //throw
                return false;
            }
        }
        public static bool AddJobDescriptionToDB(JobDescription jobDescription)
        {
            var query = "INSERT INTO JobDescriptionData(Country, Program, [Job Description], CompanyName, Language, Year, Month, Date) Values ('@Country', '@Program', '@JobDescription', '@CompanyName', '@Language', '@Year', '@Month', '@Date')";

            query = query.Replace("@Country", jobDescription.Country)
                .Replace("@Program", jobDescription.Program)
                .Replace("@JobDescription", jobDescription.jobDescription)
                .Replace("@CompanyName", jobDescription.CompanyName)
            .Replace("@Language", jobDescription.language)
            .Replace("@Year", jobDescription.year)
            .Replace("@Month", jobDescription.month)
            .Replace("@Date", jobDescription.date);

            return getSQLConnection(query);
        }

        public static bool getCompanyName(JobDescription jobDescription)
        {
            var query = "Select CASE WHEN '@Year' > Year(getdate()) THEN CompanyName WHEN '@YEAR' = Year(getdate()) AND '@Month' > Month(getdate()) THEN CompanyName WHEN '@YEAR' = Year(getdate()) AND '@Month' = Month(getdate()) AND '@Date' >= DATEPART(day, GETDATE()) THEN CompanyName Else 'No Match' END AS CompanyName from JobDescriptionData;";

            query = query.Replace("@Year", jobDescription.year)
                .Replace("@Month", jobDescription.month)
                .Replace("@Date", jobDescription.date);

            return getSQLConnection(query);
        }

        public static bool EditJobDescription(JobDescription jobDescription)
        {
            var query = "UPDATE JobDescriptionData SET Country = '@Country', Program = '@Program', [Job Description] = '@JobDescription', CompanyName = '@CompanyName', Language = '@Language' WHERE ID = '@ID'";

            query = query.Replace("@Country", jobDescription.Country)
                .Replace("@Program", jobDescription.Program)
                .Replace("@JobDescription", jobDescription.jobDescription)
                .Replace("@CompanyName", jobDescription.CompanyName)
            .Replace("@Language", jobDescription.language)
            .Replace("@ID", jobDescription.ID);

            return getSQLConnection(query);
        }
    }
}