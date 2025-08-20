using OOPExercises_Dependency.Exercise01;
using OOPExercises_Dependency.Exercise02;
using OOPExercises_Dependency.Exercise03;
using OOPExercises_Dependency.Exercise04;
using OOPExercises_Dependency.Exercise05;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exercise 01: Dependency Injection\n");

        ILogger consoleLogger = new ConsoleLogger();
        UserService userService1 = new UserService(consoleLogger);
        userService1.Log("User created successfully.");

        ILogger fileLogger = new FileLogger("LoggerFile.txt");
        UserService userService2 = new UserService(fileLogger);
        userService2.Log("User created successfully.");

        /* --------------------------------------------------------------------------------------------- */

        Console.WriteLine("\nExercise 02: Betalingsgateway\n");

        IPaymentProcessor payPalPayment = new PayPalPaymentProcessor();
        CheckoutService checkoutService1 = new CheckoutService(payPalPayment);
        checkoutService1.Process(100.00m);

        IPaymentProcessor stripePayment = new StripePaymentProcessor();
        CheckoutService checkoutService2 = new CheckoutService(stripePayment);
        checkoutService2.Process(200.00m);

        /* --------------------------------------------------------------------------------------------- */

        Console.WriteLine("\nExercise 03: E-mail afsendelse\n");

        IEmailSender emailService = new ConsoleEmailSender();
        ILogger emailLogger = new ConsoleLogger();
        NotificationService notificationService1 = new NotificationService(emailService, emailLogger);
        notificationService1.SendEmail("Anders", "Læreplads", 
            "Hej Anders, jeg ønsker at høre om i kunne være interesseret i en ny elev");

        IEmailSender smtpEmailService = new SmtpEmailSender();
        ILogger smtpEmailLogger = new FileLogger("EmailLog.txt");
        NotificationService notificationService2 = new NotificationService(smtpEmailService, smtpEmailLogger);
        notificationService2.SendEmail("Torben", "Læreplads",
            "Hej Torben, jeg ønsker at høre om i kunne være interesseret i en ny elev");

        /* --------------------------------------------------------------------------------------------- */

        Console.WriteLine("\nExercise 04: Data Repository\n");

        IProductRepository sqlRepository = new SqlProductRepository();
        ProductService productService1 = new ProductService(sqlRepository);
        productService1.AddProduct("Laptop");
        productService1.AddProduct("Smartphone");
        productService1.GetAllProducts();

        IProductRepository inMemoryRepository = new InMemoryProductRepository();
        ProductService productService2 = new ProductService(inMemoryRepository);
        productService2.AddProduct("Tablet");
        productService2.AddProduct("Smartwatch");
        productService2.GetAllProducts();

        /* --------------------------------------------------------------------------------------------- */

        Console.WriteLine("\nExercise 05: Spillogik med afhængigheder\n");

        IGameEngine GuessNumberGame = new GuessNumberGame();
        GameRunner gameRunner1 = new GameRunner(GuessNumberGame);
        gameRunner1.Play();

        IGameEngine RockPaperScissorsGame = new RockPaperScissorsGame();
        GameRunner gameRunner2 = new GameRunner(RockPaperScissorsGame);
        gameRunner2.Play();
    }
}
