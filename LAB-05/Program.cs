namespace LAB_05
{
    internal class Program
    {
        public struct Coords
        {
            //Zadanie 1
            public double X { get; }
            public double Y { get; }
            public Coords(double x, double y)
            {
                X = x;
                Y = y;
            }

            public void GetCoords(Coords b)
            {
                double result = Math.Sqrt((this.X - b.X) * (this.X - b.X) + (this.Y - b.Y) * (this.Y - b.Y));
                Console.WriteLine(result);
            }
            // Zadanie 2
            static (int Min, int Max) GetMinMax(int[] numbers)
            {
                int min = numbers[0];
                int max = numbers[0];
                foreach (int number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                    if (number > max)
                    {
                        max = number;
                    }
                }
                return (min, max);
            }

            static void Main(string[] args)
            {
                // Zadanie 1
                Coords coords = new Coords(1.0, 2.0);
                Coords coords1 = new Coords(3.0, 4.0);
                coords.GetCoords(coords1);

                //Zadanie 2
                int[] numbers = { 5, 2, 9, 1, 7, 3, 8 };
                Console.WriteLine(GetMinMax(numbers));

                //Zadanie 3
                Person john = new Person("John", "Doe", new DateTime(2000, 02, 12), "johndoe@gmail.com");
                Person elly = new Person("Elly", "Doe", new DateTime(2013, 12, 12), "ellydoe@gmail.com");
                Console.WriteLine(john.IsAdult());
                Console.WriteLine(elly.GetAge());

            }
        }
    }
}