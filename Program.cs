namespace BinaryTreeEx
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var peregrin = new Node("Peregrin", null, null);
			var meriadok = new Node("Meriadok", null, null);
			var samwise = new Node("Samwise", null, null);
			var frodo = new Node("Frodo", samwise, meriadok);
			var boromir = new Node("Boromir", peregrin, null);
			var legolas = new Node("Legolas", null, frodo);
			var gimli = new Node("Gimli", null, null);
			var aragorn = new Node("Aragorn", legolas, gimli);
			var gandalf = new Node("Gandalf", aragorn, boromir);

			PreOrder(gandalf);
			Console.WriteLine();
			InOrder(gandalf);
			Console.WriteLine();
			PostOrder(gandalf);
		}

		static void PreOrder(Node node)
		{
			if(node == null)
			{
				return;
			}

			Console.WriteLine(node.Name);
			PreOrder(node.Left);
			PreOrder(node.Right);
		}

		static void InOrder(Node node)
		{
			if (node == null)
			{
				return;
			}

			InOrder(node.Left);
			Console.WriteLine(node.Name);
			InOrder(node.Right);
		}

		static void PostOrder(Node node)
		{
			if (node == null)
			{
				return;
			}

			PostOrder(node.Left);
			PostOrder(node.Right);
			Console.WriteLine(node.Name);
		}
	}

	public class Node
	{
		public string Name { get; set; }
		public Node? Left { get; set; }
		public Node? Right { get; set; }

		public Node(string name, Node? left, Node? right)
		{
			Name = name;
			Left = left;
			Right = right;
		}
	}
}
