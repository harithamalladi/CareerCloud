﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
	public class CompanyDescriptionLogic : BaseLogic<CompanyDescriptionPoco>
	{
		public CompanyDescriptionLogic(IDataRepository<CompanyDescriptionPoco> repo) : 
			base(repo)
		{		}
		public override void Add(CompanyDescriptionPoco[] pocos)
		{
			Verify(pocos);
			base.Add(pocos);
		}

		public override void Update(CompanyDescriptionPoco[] pocos)
		{
			Verify(pocos);
			base.Update(pocos);
		}
		protected override void Verify(CompanyDescriptionPoco[] pocos)
		{
			List<ValidationException> exceptions = new List<ValidationException>();
			foreach (CompanyDescriptionPoco poco in pocos)
			{
				if (String.IsNullOrEmpty(poco.CompanyDescription))
				{
					exceptions.Add(new ValidationException
						(107, "Company Description must be greater than 2 characters"));
				}
				else if (poco.CompanyDescription.Length <= 2)
				{
					exceptions.Add(new ValidationException
						(107, "Company Description must be greater than 2 characters"));
				}
				if (String.IsNullOrEmpty(poco.CompanyName))
				{
					exceptions.Add(new ValidationException
						(106, "Company Name must be greater than 2 characters"));
				}
				else if (poco.CompanyName.Length <= 2)
				{
					exceptions.Add(new ValidationException
						(106, "Company Name must be greater than 2 characters"));
				}
			}
			if (exceptions.Count > 0)
			{
				throw new AggregateException(exceptions);
			}

		}
	}
}