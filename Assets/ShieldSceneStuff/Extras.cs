using UnityEngine;
using System.Collections;

public static class Extras {
	public static int Round(float num)
	{
		if ((int)num < num)
		{
			if (num - (int)num >= 0.5)
			{
				num = Mathf.Ceil(num);
			}
			else
			{
				num = Mathf.Floor(num);
			}
		}
		else
		{
			if ((int)num - num >= 0.5)
			{
				num = Mathf.Floor(num);
			}
			else
			{
				num = Mathf.Ceil (num);
			}
		}
		return (int)num;
	}
	public static int Round(decimal num)
	{
		if ((int)num < num)
		{
			if (num - (int)num >= (decimal)0.5)
			{
				num = (decimal)Mathf.Ceil((float)num);
			}
			else
			{
				num = (decimal)Mathf.Floor((float)num);
			}
		}
		else
		{
			if ((int)num - num >= (decimal)0.5)
			{
				num = (decimal)Mathf.Floor((float)num);
			}
			else
			{
				num = (decimal)Mathf.Ceil ((float)num);
			}
		}
		return (int) num;
	}
	public static int Round(double num)
	{
		if ((int)num < num)
		{
			if (num - (int)num >= 0.5)
			{
				num = Mathf.Ceil((float)num);
			}
			else
			{
				num = Mathf.Floor((float)num);
			}
		}
		else
		{
			if ((int)num - num >= 0.5)
			{
				num = Mathf.Floor((float)num);
			}
			else
			{
				num = Mathf.Ceil ((float)num);
			}
		}
		return (int) num;
	}
}
