namespace Assignment
{
    public class Program
    {
        public static void Main()
        {
            //Car car = new Car("Ferrari", 2023, 100000.50f);
            //car.DisplayCar();

            //BankAccount bankAccount = new BankAccount("10101010");
            //bankAccount.Deposit(1000);
            //bankAccount.Withdraw(500);
            //bankAccount.DisplayInfo();

            //Rectangle rectangle = new Rectangle(4.5f, 3.2f);
            //rectangle.DisplayArea();

            //Circle circle = new Circle(5);
            //circle.DisplayArea();

            //Student student = new Student("John Doe", 20, "Computer Science");
            //student.Introduce();

            //Calendar calendar = new Calendar();
            //calendar.PrintWeekdays();

            Print2D p1 = new Print2D();
            p1.x = 2.1f;
            p1.y = 3.2f;

            Print2D p2 = new();
            p2.x = 5.2f;
            p2.y = 4.4f;

            float distance=Print2D.CalculateDistance(p1, p2);

            Console.WriteLine(distance);


        }
    }
}

