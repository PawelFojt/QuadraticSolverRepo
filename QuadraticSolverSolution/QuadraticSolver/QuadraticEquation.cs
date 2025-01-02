namespace QuadraticSolver;

public static class QuadraticEquation
{
    private const double Tolerance = 1e-14;

    public static (int numberOfRoots, double[] roots) Solve(double a, double b, double c)
    {
        if (IsApproximatelyZero(a))
        {
            throw new ArgumentException("Parameter 'a' cannot be zero for a quadratic equation.");
        }

        var delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return (0, []);
        }
        if (IsApproximatelyZero(delta))
        {
            var x = -b / (2 * a);
            return (1, [x]);
        }

        var sqrtDelta = Math.Sqrt(delta);
        var x1 = (-b - sqrtDelta) / (2 * a);
        var x2 = (-b + sqrtDelta) / (2 * a);
        return (2, [x1, x2]);
    }

    private static bool IsApproximatelyZero(double value)
    {
        return Math.Abs(value) < Tolerance;
    }
}