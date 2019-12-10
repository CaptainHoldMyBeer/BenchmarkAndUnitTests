using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;


namespace ForVsForeach
{
	public class BenchmarkHelper
	{
		List<int> list_for = new List<int>(1000000);
		List<int> list_foreach = new List<int>(1000000);

		public BenchmarkHelper()
		{
			for (int i = 0; i < 1000000; i++)
			{
				list_for.Add(i);
				list_foreach.Add(i);
			}
		}

		[Benchmark(Description = "for cycle")]
		public void ForPerfomance()
		{
			var currentElement = 0;
			for (int i = 0; i < list_for.Capacity; i++)
				currentElement = list_for[i];
		}

		[Benchmark(Description = "foreach cycle")]
		public void ForeachPerfomance()
		{
			var currentElement = 0;
			foreach (var element in list_foreach)
				currentElement = element;
		}
	}
}
