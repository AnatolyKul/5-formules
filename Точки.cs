using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ConsoleApp13
{
	class Shape
	{
		protected  Point[] points;
		protected  Point center; 

		public Shape()
		{
			points = null;
		}
		public Shape(Point center, Point[] points)
		{
			this.center = center;
			this.points = points;
		}
		public Shape(Point[] points)
		{ }

		public void Draw()
		{
			if (points == null) return; 
			

			

		}
	}
}
