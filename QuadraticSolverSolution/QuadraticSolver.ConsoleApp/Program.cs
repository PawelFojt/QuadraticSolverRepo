namespace QuadraticSolver.ConsoleApp;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Quadratic Equation Solver ===");

        while (true)
        {
            Console.WriteLine("\nEnter 'exit' to close the application or provide the coefficients for the quadratic equation.");

            Console.Write("Enter a: ");
            var inputA = Console.ReadLine();
            if (IsExitCommand(inputA)) break;

            Console.Write("Enter b: ");
            var inputB = Console.ReadLine();
            if (IsExitCommand(inputB)) break;

            Console.Write("Enter c: ");
            var inputC = Console.ReadLine();
            if (IsExitCommand(inputC)) break;

            try
            {
                var a = double.Parse(inputA ?? "0");
                var b = double.Parse(inputB ?? "0");
                var c = double.Parse(inputC ?? "0");

                var (count, roots) = QuadraticEquation.Solve(a, b, c);

                switch (count)
                {
                    case 0:
                        Console.WriteLine("No real roots.");
                        break;
                    case 1:
                        Console.WriteLine($"One root: x = {roots[0]:F5}");
                        break;
                    case 2:
                        Console.WriteLine($"Two roots: x1 = {roots[0]:F5}, x2 = {roots[1]:F5}");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format. Please enter numeric values for a, b, and c.");
            }
        }

        Console.WriteLine("Application closed. Goodbye!");
    }

    private static bool IsExitCommand(string? input)
    {
        return string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase);
    }
}
