using IceTask1;

namespace IceTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Rectangle("MyRectangle", 5, 10);
            ((Shape)rect).Display(); // Cast to Shape to access Display()

            Console.WriteLine(); // Line break

            IShape circle = new Circle("MyCircle", 7);
            ((Shape)circle).Display(); // Cast to Shape to access Display()
        }

    }
}


