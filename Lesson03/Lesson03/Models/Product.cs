
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson03.Models
{
	public class Product
	{

		// Static read-only automatic property
		public static decimal Moms { get; private set; } = 0.25M;
		

		// Automatic properties
		public string Name { get; set; }
		public double Price { get; set; }
				
	}

}
