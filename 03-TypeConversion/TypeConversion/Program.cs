namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //int i1 = 1;
            //byte b1 = i1; // Cannot implicitly convert
            //Console.WriteLine(i); 

            int i1 = 1;
            byte b1 = (byte) i1; 
            Console.WriteLine(i);

            var number = "1234";
            //int i2 = (int) number;
            int i2 = Convert.ToInt32(number);
            Console.WriteLine(i2);

            try
            {
                var number1 = "1234";
                int i3 = Convert.ToByte(number1);
                Console.WriteLine(i3);
            }
            catch (Exception) 
            {
                Console.WriteLine("The number cannot be converted to Byte");
            }

            string str = "true";
            bool b2 = Convert.ToBoolean(str);
            Console.WriteLine(b2);
        }
    }
}