using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
	public class SystemCountryCodeLogic
	{
		IDataRepository<SystemCountryCodePoco> _repo;
		public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repo)
		{
			_repo = repo;
		}
		public void Add(SystemCountryCodePoco[] pocos)
		{
			Verify(pocos);
			_repo.Add(pocos);
		}

		public void Update(SystemCountryCodePoco[] pocos)
		{
			Verify(pocos);
			_repo.Update(pocos);
		}
		public void Delete(SystemCountryCodePoco[] pocos)
		{
			_repo.Remove(pocos);
		}
		public List<SystemCountryCodePoco> GetAll()
		{
			return _repo.GetAll().ToList();
		}

		public SystemCountryCodePoco Get(String code)
		{
			return _repo.GetSingle(c => c.Code == code);
		}
		protected void Verify(SystemCountryCodePoco[] pocos)
		{
			List<ValidationException> exceptions = new List<ValidationException>();
			foreach (SystemCountryCodePoco poco in pocos)
			{

				if (String.IsNullOrEmpty(poco.Code))
				{
					exceptions.Add(new ValidationException(900, "Code cannot be empty"));
				}

				if (String.IsNullOrEmpty(poco.Name))
				{
					exceptions.Add(new ValidationException(901, "Name cannot be empty"));
				}
			}
			if (exceptions.Count > 0)
			{
				throw new AggregateException(exceptions);
			}

		}
	}
}