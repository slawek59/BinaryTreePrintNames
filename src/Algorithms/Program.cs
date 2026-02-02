namespace Algorithms
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] collectionArray = { 9, 7, 5, 3, 3, 1, 2, 4, 8, 6, 0, 10 };
			List<int> collectionList = new() { 9, 7, 5, 3, 3, 1, 2, 4, 8, 6, 0, 10 };
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

			foreach (var item in collectionArray)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in collectionArray.BubbleSort())
			{
				Console.WriteLine(item);
			}

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

			var swapCounter = 0;

			do
			{
				swapCounter = 0;
				for (int i = 0; i < collection.Count - 1; i++)
				{

					if (collection[i].CompareTo(collection[i + 1]) > 0)
					{
						(collection[i], collection[i + 1]) = (collection[i + 1], collection[i]);
						swapCounter++;
					}
				}

			} while (swapCounter != 0);

			return collection;
		}
	}
}
