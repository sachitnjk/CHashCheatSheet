using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHashLearn
{
	internal class BasicsLearnCode
	{

		private float xPos, yPos;

		public BasicsLearnCode()
		{
			xPos = 0;
			yPos = 0;
		}

		public BasicsLearnCode(float xPos, float yPos)
		{
			this.xPos = xPos;
			this.yPos = yPos;

			Console.WriteLine($"xPos:{this.xPos}, yPos{this.yPos}");
		}


		public void SeperatingCommentPassRef()
		{
			Console.WriteLine("Below is the output example of passing with reference");
		}

		public void ExamplePassWithRef()
		{
			float anotherFloat = 40f;
			Subtract(10, 5, anotherFloat);
			Console.WriteLine(anotherFloat);                          //withought ref, change to outValue does not affect anotherFloat	
			SubtractWithRef(10, 5, ref anotherFloat);
			Console.WriteLine(anotherFloat);                          //with ref, change to outValue affects anotherFloat
		}

		void Subtract(float a, float b, float outValue)
		{
			outValue = a - b;

		}

		void SubtractWithRef(float a, float b, ref float outValue)
		{
			outValue = a - b;
		}


		public void NewLineFucntion()
		{
			Console.WriteLine("\n");
		}


		public void SeperatingCommmentOverloading()
		{
			Console.WriteLine("Below is the output example of overloading where one function can take two inputs as well as three:");
		}


		public void ExampleOfOverloading()
		{
			int addedValue = (int)AddFunction(5, 10);         //AddFunction() here is casted into int - returns float by default
			Console.WriteLine($"addedValue is giving two inputs to AddFunction(): {addedValue}");
			float addedValue2 = AddFunction(5, 10, 20);       //AddFunction() here not casted into int - returns float by default
			Console.WriteLine($"addedValue2 is giving three inputs to AddFunction(): {addedValue2}");
		}

		float AddFunction(float a, float b)
		{
			float c = a + b;

			return c;

		}

		float AddFunction(float a, float b, float d)
		{
			float c = a + b + d;

			return c;                                   //return is always the endline(terminatin point)

		}


		public void SeperatingCommmentCasting()
		{
			Console.WriteLine("Below is the output example of casting and also gives o/p as 10 showing that it gives lower limit value by default:");
		}


		public void ExampleOfCasting()
		{
			float testFloat = 10.8f;
			int floatToInt = (int)testFloat;   // Gives op as 10 as it gives the lower limit
			Console.WriteLine(floatToInt);
		}



		int CanSeePlayer(bool playerInView, bool allyInView)
		{
			if (playerInView)
			{
				return 1;
				//int jeebs = 2;							// this will not run as return is the termination point
			}

			if (allyInView)
			{
				return 3;
			}
			else
			{
				return 4;                                 // there should always be a return value present for it to work if no return value is specified then error
			}
		}


	}

}

