using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Creating_Exceptions
{
	internal class InvalidRadiusException : Exception
	{
		public InvalidRadiusException() : base("Radius is greater than zero.")
		{
			
		}

		public InvalidRadiusException(double radius) : base($"Radius {radius} is not valid")
		{

		}
		public InvalidRadiusException (string message) : base(message) { }
	}
}
