using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_Demo
{
	public class User           //Step 1 : class to create a table and columns
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
	public class UserDbContext : DbContext   //it is an abstraction over to the database that is used to load or save the data
	//step 2 : to create a class that derives from DbContext and expose one or more DbSets
	{
		public DbSet<User> user { get; set; }
	}
	 //Step 3 : Go to App.config and create a connection string 
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
