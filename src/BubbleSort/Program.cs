using System.Collections.Immutable;

namespace BubbleSort
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[] collectionArray = { 9, 7, 5, 3, 3, 1, 2, 4, 8, 6, 0, 10 };
			List<int> collectionList = new() { 9, 7, 5, 3, 3, 1, 2, 4, 8, 6, 0, 10 };

			foreach (var item in collectionArray)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in BubbleSort(collectionArray))
			{
				Console.WriteLine(item);
			}

			foreach (var item in collectionList)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine();

			foreach (var item in BubbleSort(collectionList))
			{
				Console.WriteLine(item);
			}
		}

		static IEnumerable<T> BubbleSort<T>(IList<T> collection) where T : IComparable<T>
		{
			if (collection is null)
			{
				throw new ArgumentException();
			}

			var swapCounter = 0;

			do
			{
				swapCounter = 0;
				for (int i = 0; i < collection.Count - 1; i++)
				{

					if (collection[i].CompareTo(collection[i + 1]) > 0)
					{
						var tmp = collection[i + 1];
						collection[i + 1] = collection[i];
						collection[i] = tmp;
						swapCounter++;
					}
				}


			} while (swapCounter != 0);

			return collection;
		}
	}
}
