using System;
namespace Examen
{
	public class Employee : Person
	{
		private double salary;
		private String name;

		public Employee(string name, DateTime birthday, double salary) : base(name, birthday)
		{
			this.salary = salary;
			this.name = " Bullshit ";
			//base.name = " Shitbull ";
		}

		public double GetSalary()
		{
			return this.salary;
		}

		//public override string ToString()
		//{
		//	return string.Format(" {0} ", name);
		//	//return "marchand";
		//}
	}
}
