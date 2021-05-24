using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Reactage :Shape
	{
		public Reactage (Point p1, Point p2, Point p3, Point p4)
		{
			points = new Point[4];
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
			points[3] = p4;
		}
		
	}
}
