using System;

namespace SimplifyUVS
{
	public class ExampleData
	{
		public string ID;
		public int Number;
		public bool IsSet;

		public override string ToString()
		{
			return $"{ID} : {Number} : IsSet";
		}
	}

	public struct ExampleDataStruct
	{
		public string ID;
		public int Number;
		public bool IsSet;

		public override string ToString()
		{
			return $"{ID} : {Number} : IsSet";
		}
	}

}
