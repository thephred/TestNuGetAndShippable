using NUnit.Framework;
using System;

namespace tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestCase ()
		{
			Assert.AreEqual (1, 1);
		}

		[Test ()]
		public void AnotherTestCase ()
		{
			Assert.AreEqual (2, 2);
		}
	}
}

