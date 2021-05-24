﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
	class Треугольник : Формулы
	{
		public Треугольник(int side1, int side2, int height, int radius, int diagonal, int side3, int side4)
			: base(side1, side2, height, radius, diagonal, side3, side4)
		{
		}
		internal override double square()
		{
			int c = Side1;
			int h = Height;
			int S = c * h / 2;
			Console.WriteLine("Плошадь треугольника: " + S);
			return S;
		}
		internal override double Perimetr()
		{
			int a = Side1;
			int b = Side2;
			int c = Side3;
			int d = Side4;
			int P = a + b + c + d;
			Console.WriteLine("Периметр треугольника: " + P);
			return P;
		}
	}
}
