using NUnit.Framework;

namespace SeminarStandard
{
	[TestFixture]
	public class GreetingTests
	{
		// TODO Setup/TearDown 
		// TODO TESTCASE
		Greeting greeting = new Greeting();

		[Test]
		public void ShouldGreetBob()
		{
			ExecuteTest("Bob", "Hello, Bob.");
		}

		public void ExecuteTest(string name, string expected)
		{
			TransformStr(name);
			//Arrange

			//Act
			string result = greeting.Greet(name);

			//Assert
			Assert.AreEqual(expected, result);
		}

		public void TransformStr (string name)
        {
			string[] name = new string[2]; 

			for(int i=0; i<=1; i++)
            {
				name[i] = name;
            }

        }

		[Test]
		public void ShouldGreetGigi()
		{
			ExecuteTest("Gigi", "Hello, Gigi.");
		}


		[Test]
		public void ShouldHandleNull()
		{
			ExecuteTest(null, "Hello, my friend.");
		}

		[Test]
		public void ShouldHandleShouting()
		{
			ExecuteTest("JERRY", "HELLO JERRY!");
		}

		[Test]
		public void ShouldHandleTwo()
		{
			ExecuteTest(["Jill", "Jane"], "Hello, Jill and Jane.");
		}

		[Test]
		public void ShouldHandleMore()
		{
			ExecuteTest(["Amy", "Brian", "Charlotte"], "Hello, Amy, Brian, and Charlotte.");
		}

		[Test]
		public void ShouldHandleMixing()
		{
			ExecuteTest(["Amy", "BRIAN", "Charlotte"], "Hello, Amy and Charlotte. AND HELLO BRIAN!");
		}
		
		[Test]
		public void ShouldHandleComma()
		{
			ExecuteTest(["Bob", "Charlie, Dianne"], "Hello, Bob, Charlie, and Dianne.");
		}

		[Test]
		public void ShouldHandleEight()
		{
			ExecuteTest(["Bob", "\"Charlie, Dianne\""], "Hello, Bob and Charlie, Dianne.");
		}
	}
}
