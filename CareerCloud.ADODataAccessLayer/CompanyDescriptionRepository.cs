using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CareerCloud.ADODataAccessLayer
{
    public class CompanyDescriptionRepository : BaseADO,IDataRepository<CompanyDescriptionPoco>
    {
        public void Add(params CompanyDescriptionPoco[] items)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (CompanyDescriptionPoco item in items)
            {
                cmd.CommandText = @"INSERT INTO [dbo].[Company_Descriptions]
                                    ([Id]
                                    ,[Company]
                                    ,[LanguageID]
                                    ,[Company_Name]
                                    ,[Company_Description])
                                VALUES
                                    (@Id,
                                    @Company,
                                    @LanguageID,
                                    @CompanyName,
                                    @CompanyDescription)";

                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Company", item.Company);
                cmd.Parameters.AddWithValue("@LanguageID", item.LanguageId);
                cmd.Parameters.AddWithValue("@CompanyName", item.CompanyName);
                cmd.Parameters.AddWithValue("@CompanyDescription", item.CompanyDescription);
                
                conn.Open();
                int rowEffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyDescriptionPoco> GetAll(params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                                          ,[Company]
                                          ,[LanguageID]
                                          ,[Company_Name]
                                          ,[Company_Description]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Company_Descriptions]";

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                int counter = 0;
                CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[10000];
                while (rdr.Read())
                {
                    CompanyDescriptionPoco poco = new CompanyDescriptionPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Company = rdr.GetGuid(1);
                    poco.LanguageId = rdr.GetString(2);
                    poco.CompanyName = rdr.GetString(3);
                    poco.CompanyDescription = rdr.GetString(4);
                    poco.TimeStamp = (byte[])rdr[5];

                    pocos[counter] = poco;
                    counter++;
                }
                conn.Close();

                return pocos.Where(p => p != null).ToList();

            }
        }

        public IList<CompanyDescriptionPoco> GetList(Expression<Func<CompanyDescriptionPoco, bool>> where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyDescriptionPoco GetSingle(Expression<Func<CompanyDescriptionPoco, bool>> where, params Expression<Func<CompanyDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }   

        public void Remove(params CompanyDescriptionPoco[] items)
        {
        using SqlConnection conn = new SqlConnection(_connectionString);
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (var item in items)
            {
                cmd.CommandText = @"DELETE FROM [dbo].[Company_Descriptions]
                                        WHERE [Id] = @Id";

                cmd.Parameters.AddWithValue("@Id", item.Id);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }

        public void Update(params CompanyDescriptionPoco[] items)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Descriptions]
                                       SET [Id] = @Id
                                          ,[Company] = @Company
                                          ,[LanguageID] = @LanguageID
                                          ,[Company_Name] = @CompanyName
                                          ,[Company_Description] = @CompanyDescription
                                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageId);
                    cmd.Parameters.AddWithValue("@CompanyName", item.CompanyName);
                    cmd.Parameters.AddWithValue("@CompanyDescription", item.CompanyDescription);
                   
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
