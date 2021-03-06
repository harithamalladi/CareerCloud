using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
	public class SystemLanguageCodeLogic
	{
		IDataRepository<SystemLanguageCodePoco> _repo;
		public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repo)
		{
			_repo = repo;
		}
		public void Add(SystemLanguageCodePoco[] pocos)
		{
			Verify(pocos);
			_repo.Add(pocos);
		}

		public void Update(SystemLanguageCodePoco[] pocos)
		{
			Verify(pocos);
			_repo.Update(pocos);
		}

		public void Delete(SystemLanguageCodePoco[] pocos)
		{
			_repo.Remove(pocos);
		}

		public List<SystemLanguageCodePoco> GetAll()
		{
			return _repo.GetAll().ToList();
		}

		public SystemLanguageCodePoco Get(String languageID)
		{
			return _repo.GetSingle(c => c.LanguageID == languageID);
		}
		protected void Verify(SystemLanguageCodePoco[] pocos)
		{
			List<ValidationException> exceptions = new List<ValidationException>();
			foreach (SystemLanguageCodePoco poco in pocos)
			{
				if (string.IsNullOrEmpty(poco.LanguageID))
				{
					exceptions.Add(new ValidationException(1000, "LanguageID cannot be empty"));
				}

				if (string.IsNullOrEmpty(poco.Name))
				{
					exceptions.Add(new ValidationException(1001, "Name cannot be empty"));
				}
				if (string.IsNullOrEmpty(poco.NativeName))
				{
					exceptions.Add(new ValidationException(1002, "Native Name cannot be empty"));
				}
			}
			if (exceptions.Count > 0)
			{
				throw new AggregateException(exceptions);
			}
		}
	}
}