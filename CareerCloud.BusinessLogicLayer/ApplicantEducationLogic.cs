using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class ApplicantEducationLogic : BaseLogic<ApplicantEducationPoco>
    {
        public ApplicantEducationLogic(IDataRepository<ApplicantEducationPoco> repo) 
            : base(repo) { }

        public override void Add(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }
        public override void Update(ApplicantEducationPoco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
        protected override void Verify(ApplicantEducationPoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();
            foreach(ApplicantEducationPoco poco in pocos)
            {
                if(string.IsNullOrEmpty(poco.Major))
                {
                    exceptions.Add(new ValidationException
                       (107, $"{poco.Id}"));
                }
                else if(poco.Major.Length < 3)
                {
                    exceptions.Add(new ValidationException
                        (107, $"{poco.Id}"));
                }
                if(poco.StartDate > DateTime.Now )
                {
                    exceptions.Add(new ValidationException
                        (108, "Something Wrong"));
                }
                if(poco.CompletionDate < poco.StartDate) 
                {
                    exceptions.Add(new ValidationException
                        (109, "Completion Date is before start date"));
                }
                if(exceptions.Count > 0)
                {
                    throw new AggregateException(exceptions);
                }
            }

        }
    }
}
