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
    public class CompanyJobEducationRepository : BaseADO,IDataRepository<CompanyJobEducationPoco>
    {
        public void Add(params CompanyJobEducationPoco[] items)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            foreach (CompanyJobEducationPoco item in items)
            {
                cmd.CommandText = @"INSERT INTO [dbo].[Company_Job_Educations]
                                   ([Id]
                                   ,[Job]
                                   ,[Major]
                                   ,[Importance])
                             VALUES
                                   (@Id,
                                   @Job,
                                   @Major,
                                   @Importance)";

                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Job", item.Job);
                cmd.Parameters.AddWithValue("@Major", item.Major);
                cmd.Parameters.AddWithValue("@Importance", item.Importance);

                conn.Open();
                int rowEffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyJobEducationPoco> GetAll(params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT [Id]
                                          ,[Job]
                                          ,[Major]
                                          ,[Importance]
                                          ,[Time_Stamp]
                                      FROM [dbo].[Company_Job_Educations]";

                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                int counter = 0;
                CompanyJobEducationPoco[] pocos = new CompanyJobEducationPoco[10000];
                while (rdr.Read())
                {
                    CompanyJobEducationPoco poco = new CompanyJobEducationPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Job = rdr.GetGuid(1);
                    poco.Major = rdr.GetString(2);
                    poco.Importance = rdr.GetInt16(3);
                    poco.TimeStamp = (byte[])rdr[4];

                    pocos[counter] = poco;
                    counter++;
                }
                conn.Close();

                return pocos.Where(p => p != null).ToList();

            }
        }

        public IList<CompanyJobEducationPoco> GetList(Expression<Func<CompanyJobEducationPoco, bool>> where, params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobEducationPoco GetSingle(Expression<Func<CompanyJobEducationPoco, bool>> where, params Expression<Func<CompanyJobEducationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobEducationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobEducationPoco[] items)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var item in items)
                {
                    cmd.CommandText = @"DELETE FROM [dbo].[Company_Job_Educations]
                                        WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params CompanyJobEducationPoco[] items)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                foreach (var item in items)
                {
                    cmd.CommandText = @"UPDATE [dbo].[Company_Job_Educations]
                                           SET [Id] = @Id
                                              ,[Job] = @Job
                                              ,[Major] = @Major
                                              ,[Importance] = @Importance
                                      WHERE [Id] = @Id";

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Major", item.Major);
                    cmd.Parameters.AddWithValue("@Importance", item.Importance);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
