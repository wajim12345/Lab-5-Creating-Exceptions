using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_Creating_Exceptions
{
	internal class Circle
	{
		public double Radius { get; set; }

		public Circle()
		{
			
		}



		//SetRadius method: checks whether the radius is greater than zero.If the radius is greater than zero, it sets it.If the radius is equal to or less than zero, the method throws the exception InvalidRadiusException
		public void SetRadius(double radius)
		{
			if (radius > 0)
			{
				Radius = radius;
			}
			else
			{
				throw new InvalidRadiusException(radius);
			}
			
		}
		//ToString method: displays all circle object information(radius)
		public override string ToString()
		{
			return $"Radius = {Radius}";
		}
	}
}
