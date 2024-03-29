﻿namespace LTWindows.Core
{
	internal class Matrix
	{
		public int[,] matrix { get; set; }
		public int SoDong { get; }
		public int SoCot { get; }

		public bool isSquare { get => SoCot == SoDong; }

		public Matrix(int SoCot, int SoDong)
		{
			try
			{
				this.SoDong = SoDong;
				this.SoCot = SoCot;
				matrix = new int[SoDong, SoCot];
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		public static int TotalDiagonalRightToLeft(Matrix a)
		{
			int result = 0;

			for (int i = 0; i < a.SoDong; i++)
			{
				result += a.matrix[i, i];
			}

			return result;
		}

		public static int TotalDiagonalLeftToRight(Matrix a)
		{
			int result = 0;

			for (int i = 0; i < a.SoDong; i++)
			{
				int j = a.SoCot - i - 1;
				result += a.matrix[i, j];
			}

			return result;
		}

		public static Matrix Multiplication(Matrix a, Matrix b)
		{
			if (a.SoDong != b.SoCot)
			{
				MessageBox.Show("Không tính được!");
				return null;
			}

			Matrix result = new(a.SoDong, b.SoCot);

			for (int i = 0; i < result.SoDong; i++)
			{
				for (int j = 0; j < result.SoCot; j++)
				{
					result.matrix[i, j] = 0;
					for (int r = 0; r < a.SoDong; r++)
					{
						result.matrix[i, j] += a.matrix[i, r] * b.matrix[r, j];
					}
				}
			}

			return result;
		}

		public static Matrix Plus(Matrix a, Matrix b)
		{
			if (a.SoCot != b.SoCot || a.SoDong != b.SoDong)
			{
				MessageBox.Show("Không tính được!");
				return null;
			}

			Matrix result = new(a.SoCot, a.SoDong);

			for (int i = 0; i < a.SoDong; i++)
			{
				for (int j = 0; j < a.SoCot; j++)
				{
					result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
				}
			}

			return result;
		}


		public static bool isUpperTriangular(Matrix a)
		{
			if (!a.isSquare) return false;

			for (int i = 0; i < a.SoDong; i++)
			{
				for (int j = i + 1; j < a.SoCot; j++)
				{
					if (a.matrix[i, j] != 0) return false;
				}
			}

			return true;
		}

	}
}
