// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
namespace CHashLearn // Note: actual namespace depends on the project name.
{
	internal class Program
	{

		static void Main(string[] args)
		{


			BasicsLearnCode newItem = new BasicsLearnCode();
			newItem.SeperatingCommentPassRef();
			newItem.ExamplePassWithRef();

			newItem.NewLineFucntion();

			newItem.SeperatingCommmentCasting();
			newItem.ExampleOfCasting();

			newItem.NewLineFucntion();

			newItem.SeperatingCommmentOverloading();
			newItem.ExampleOfOverloading();

			newItem.NewLineFucntion();


		}


	}
}
