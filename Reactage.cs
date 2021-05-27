using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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
		public Reactage (Point center,double width,double height)
		{
			points = new Point[4];
			{
				double w = width = 0.5;
				double h = height + 0.5;

				points[0] = new Point(center.x - w, center.y + h);
				points[1] = new Point(center.x + w, center.y + h);
				points[2] = new Point(center.x + w, center.y - h);
				points[3] = new Point(center.x - w, center.y - h);

			}
			
		}


	}
}
