class Rectangle
{
	private int _a;
	private int _b;

	public Rectangle(int a, int b)
	{
		_a = a;
		_b = b;
	}

	public int GetA()
	{
		return _a;
	}

	public int GetB()
	{
		return _b;
	}

	public int GetArea()
	{
		return _a * _b;
	}

	public int GetPerimeter()
	{
		return (_a * 2) + (_b * 2);
	}

	public void SetA(int a)
	{
		_a = a;
	}

	public void SetB(int b)
	{
		_b = b;
	}
}