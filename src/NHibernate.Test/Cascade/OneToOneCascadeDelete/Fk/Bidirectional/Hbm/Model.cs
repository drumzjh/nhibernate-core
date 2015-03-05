﻿namespace NHibernate.Test.Cascade.OneToOneCascadeDelete.Fk.Bidirectional.Hbm
{
	public class Employee
	{
		public virtual long Id { get; set; }
		public virtual string Name { get; set; }
		public virtual EmployeeInfo Info { get; set; }

		public Employee()
		{
		}
	}

	public class EmployeeInfo
	{
		public virtual long Id { get; set; }
		public virtual Employee EmployeeDetails { get; set; }

		public EmployeeInfo()
		{
		}

		public EmployeeInfo(Employee emp)
		{
			EmployeeDetails = emp;
		}
	}
}
