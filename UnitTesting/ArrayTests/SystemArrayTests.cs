using System;
using NUnit.Framework;

namespace Tests
{
	public class SystemArrayTests
	{
		[Test]
		public void CreateInstance_CalledWithTypeAndSize_ReturnsEmptyArrayOfTypeWithSize()
		{
			var expected = new int[10];

			var actual = Array.CreateInstance(typeof(Int32), 10);

			Assert.AreEqual(actual, expected);
		}
		[Test]
		public void Empty_CalledWithType_ReturnsEmptyArrayWithType()
		{
			var expected = new int[] { };

			var actual = Array.Empty<int>();

			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void Clone_CalledByArray_ReturnsItsClone()
		{
			var expected = new int[10];

			var actual = expected.Clone();

			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void Resize_CalledWithArrayAndSize_ChangingArraySize()
		{
			var emptyArray = new int[10];
			var expected = emptyArray.Length;

			var smallerEmptyArray = new int[2];
			Array.Resize(ref smallerEmptyArray, emptyArray.Length);
			var actual = smallerEmptyArray.Length;

			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void TrueForAll_CalledWithArrayAndPredicate_ReturnsBooleanExpression()
		{
			var emptyArray = new int[10];
			var expected = true;

			var actual = Array.TrueForAll(emptyArray, element => element == 0);

			Assert.That(actual,Is.EqualTo(expected));
		}

		[Test]
		public void GetLength_CalledByArray_ReturnsItsLength()
		{
			var emptyArray = new int[10];
			var expected = 10;

			var actual = emptyArray.GetLength(0);

			Assert.That(actual,Is.EqualTo(expected));
		}

		[Test]
		public void Copy_ReceivesArray_ReturnsItsCopy()
		{
			var expected = new int[] { 1, 2, 3, 4, 5 };

			var actual = new int[5];
			Array.Copy(expected, actual, actual.Length);

			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void Reverse_ReceivesArray_ReturnsReversed()
		{
			var expected = new[] { 1, 2, 3, 4, 5 };
			var actual = new int[] { 5, 4, 3, 2, 1 };

			Array.Reverse(actual);

			Assert.AreEqual(actual, expected);

		}

		[Test]
		public void Sort_ReceivesUnsortedArray_ReturnsSorted()
		{
			var expected = new[] { 1, 2, 3, 4, 5 };
			var actual = new[] { 3, 2, 4, 1, 5 };

			Array.Sort(actual);

			Assert.AreEqual(actual, expected);

		}

		[Test]
		public void BinarySearch_ReceivesArrayAndValue_ReturnsIndex()
		{
			var expected = 4;
			var SequentialNumbers = new[] { 1, 2, 3, 4, 5 };

			var actual = Array.BinarySearch(SequentialNumbers, 5);

			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}