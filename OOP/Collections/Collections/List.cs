using System;

namespace VladMoisak.Collections;

public class List
{
	private int[] _items;

	public List()
	{
		_items = new int[0];
	}

	public int Count
	{
		get
		{
			return _items.Length;
		}
	}

	public int this[int index]
	{
		get { return _items[index]; }
		set { _items[index] = value; }
	}

	public void Add(int item)
	{
		int newLength = _items.Length + 1;
		int[] items = new int[newLength];

		for (int i = 0; i < _items.Length; i++)
		{
			items[i] = _items[i];
		}

		items[newLength - 1] = item;

		_items = items;
	}

	public void Insert(int index, int item)
	{
		int oldCount = Count;
		int newCount = oldCount + 1;
		int[] items = new int[newCount];

		for (int i = 0; i < index; i++)
		{
			items[i] = _items[i];
		}

		items[index] = item;

		for (int i = index; i < oldCount; i++)
		{
			items[i + 1] = _items[i];
		}

		_items = items;
	}

	public void Remove(int index)
	{
		int oldCount = Count;
		int newCount = oldCount - 1;
		int[] items = new int[newCount];

		for (int i = 0; i < index; i++)
		{
			items[i] = _items[i];
		}

		for (int i = index + 1; i < oldCount; i++)
		{
			items[i - 1] = _items[i];
		}
	}
}