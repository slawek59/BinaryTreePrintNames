namespace Algorithms
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] collectionArray = { 3, 1, 0, 4, 4, 5, 2 };
			List<int> collectionList = new() { 3, 1, 0, 4, 4, 5, 2 };
			List<string> collectionListOfStrings = new List<string>() { "cda", "adc", "abc" };

			foreach (var item in collectionListOfStrings)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in collectionListOfStrings.BubbleSort())
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in collectionArray)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in collectionArray.BubbleSort())
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in collectionList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in collectionList.BubbleSort())
			{
				Console.WriteLine(item);
			}
		}
	}

	public static class IListExtensions
	{
		public static IList<T> BubbleSort<T>(this IList<T> collection) where T : IComparable<T>
		{
			if (collection is null)
			{
				throw new ArgumentNullException(nameof(collection));
			}

			if (collection.Count < 2)
			{
				return collection;
			}

			for (int i = 0; i < collection.Count - 1; i++)
			{
				var wasSwapped = false;

				for (int j = 0; j < collection.Count - 1 - i; j++)
				{
					if (collection[j].CompareTo(collection[j + 1]) > 0)
					{
						(collection[j], collection[j + 1]) = (collection[j + 1], collection[j]);

						wasSwapped = true;
					}
				}

				if (!wasSwapped)
				{
					break;
				}

			}

			return collection;
		}

		public static int LinearSearch<T>(this IList<T> collection, T searchedValue, out T? result) where T : IEquatable<T> 
		{
			if(collection is null)
			{
				throw new ArgumentNullException(nameof(collection));
			}

			for (int i = 0; i < collection.Count; i ++)
			{
				if (EqualityComparer<T>.Default.Equals(collection[i], searchedValue))
				{
					result = collection[i];
					return i;
				}
			}

			result = default;
			return -1;
		}
	}
}
