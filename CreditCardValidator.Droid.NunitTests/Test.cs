using NUnit.Framework;
using System;

namespace CreditCardValidator.Droid.NunitTests
{
	[TestFixture ()]
	public class Test
	{
		[SetUp]
		public void Setup ()
		{
		}


		[TearDown]
		public void Tear ()
		{
		}

		[Test]
		public void Pass ()
		{
			Console.WriteLine ("test1");
			Assert.True (true);
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}

		[Test]
		public void Inconclusive ()
		{
			Assert.Inconclusive ("Inconclusive");
		}
	}
}

