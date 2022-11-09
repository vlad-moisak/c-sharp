using Xunit;

namespace VladMoisak.Collections.Tests;

public class ListTests
{
	[Fact]
	public void Test_Empty()
	{
		// Act.

		var list = new List();

		// Assert.

		Assert.Equal(0, list.Count);
	}

	[Fact]
	public void Test_Add()
	{
		List list = new List();
		Assert.Equal(0, list.Count);

		list.Add(13);
		Assert.Equal(1, list.Count);
		Assert.Equal(13, list[0]);

		list.Add(1997);
		Assert.Equal(2, list.Count);
		Assert.Equal(13, list[0]);
		Assert.Equal(1997, list[1]);

		list.Add(1980);
		Assert.Equal(3, list.Count);
		Assert.Equal(13, list[0]);
		Assert.Equal(1997, list[1]);
		Assert.Equal(1980, list[2]);
	}

	[Fact]
	public void Test_Insert()
	{
		List list = new List();
		Assert.Equal(0, list.Count);

		list.Insert(0, 5);
		Assert.Equal(1, list.Count);
		Assert.Equal(5, list[0]);

		list.Insert(0, 10);
		Assert.Equal(2, list.Count);
		Assert.Equal(10, list[0]);
		Assert.Equal(5, list[1]);

		list.Insert(0, 15);
		Assert.Equal(3, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(10, list[1]);
		Assert.Equal(5, list[2]);

		list.Insert(1, 100);
		Assert.Equal(4, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(100, list[1]);
		Assert.Equal(10, list[2]);
		Assert.Equal(5, list[3]);

		list.Insert(2, 200);
		Assert.Equal(5, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(100, list[1]);
		Assert.Equal(200, list[2]);
		Assert.Equal(10, list[3]);
		Assert.Equal(5, list[4]);

		list.Insert(3, 300);
		Assert.Equal(6, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(100, list[1]);
		Assert.Equal(200, list[2]);
		Assert.Equal(300, list[3]);
		Assert.Equal(10, list[4]);
		Assert.Equal(5, list[5]);

		list.Insert(5, 33);
		Assert.Equal(7, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(100, list[1]);
		Assert.Equal(200, list[2]);
		Assert.Equal(300, list[3]);
		Assert.Equal(10, list[4]);
		Assert.Equal(33, list[5]);
		Assert.Equal(5, list[6]);

		list.Insert(6, 66);
		Assert.Equal(8, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(100, list[1]);
		Assert.Equal(200, list[2]);
		Assert.Equal(300, list[3]);
		Assert.Equal(10, list[4]);
		Assert.Equal(33, list[5]);
		Assert.Equal(66, list[6]);
		Assert.Equal(5, list[7]);

		list.Insert(7, 99);
		Assert.Equal(9, list.Count);
		Assert.Equal(15, list[0]);
		Assert.Equal(100, list[1]);
		Assert.Equal(200, list[2]);
		Assert.Equal(300, list[3]);
		Assert.Equal(10, list[4]);
		Assert.Equal(33, list[5]);
		Assert.Equal(66, list[6]);
		Assert.Equal(99, list[7]);
		Assert.Equal(5, list[8]);
	}

	[Fact]
	public void Test_Remove()
	{
		// Arrange.

		List list = new List();

		list.Add(22);
		list.Add(33);
		list.Add(44);
		list.Add(55);
		list.Add(66);

		// Act & Assert.

		list.Remove(2);
		Assert.Equal(4, list.Count);
		Assert.Equal(22, list[0]);
		Assert.Equal(33, list[1]);
		Assert.Equal(55, list[2]);
		Assert.Equal(66, list[3]);

		list.Remove(0);
		Assert.Equal(3, list.Count);
		Assert.Equal(33, list[0]);
		Assert.Equal(55, list[1]);
		Assert.Equal(66, list[2]);

		list.Remove(2);
		Assert.Equal(2, list.Count);
		Assert.Equal(33, list[0]);
		Assert.Equal(55, list[1]);

		list.Remove(0);
		Assert.Equal(1, list.Count);
		Assert.Equal(55, list[0]);

		list.Remove(0);
		Assert.Equal(0, list.Count);
	}
}