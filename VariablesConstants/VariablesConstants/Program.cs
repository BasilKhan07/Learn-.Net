namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Byte number; wrong

            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Basil";
            bool isWorking = true;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            var number1 = 2;
            var count1 = 10;
            var totalPrice1 = 20.95f;
            var character1 = 'A';
            var firstName1 = "Basil";
            var isWorking1 = true;

            Console.WriteLine(number1.GetType());
            Console.WriteLine(count1.GetType());
            Console.WriteLine(totalPrice1.GetType());
            Console.WriteLine(character1.GetType());
            Console.WriteLine(firstName1.GetType());
            Console.WriteLine(isWorking1.GetType());

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            const float Pi = 3.142f;
            //Pi = 1; cant do

        }
    }
}