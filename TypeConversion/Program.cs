namespace TypeConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b = 1;
			int i = b;
			Console.WriteLine(i);

			/*int i = 1000;
			byte b = (byte)i;
			Console.WriteLine(b);*/

			var number1 = "1234";
			int integer = Convert.ToInt32(number1);
			Console.WriteLine(integer);

			try
			{
				var number2= "1234";
				int string1 = Convert.ToByte(number2);
				Console.WriteLine(string1);
			}
			catch (Exception)
			{
				Console.WriteLine("The number could not be converted to a byte");
			}

			try
			{
				string str = "true";
				bool word = Convert.ToBoolean(str);
				Console.WriteLine(word);
			}
			catch (Exception)
			{
				Console.WriteLine("The number could not be converted to a byte");
			}
		}
	}
}