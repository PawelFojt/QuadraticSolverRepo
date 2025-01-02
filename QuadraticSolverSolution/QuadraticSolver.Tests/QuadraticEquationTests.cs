namespace QuadraticSolver.Tests;

public class QuadraticEquationTests
    {
        [Fact]
        public void Solve_ShouldReturnZeroRoots_WhenDeltaIsNegative()
        {
            var (count, roots) = QuadraticEquation.Solve(1, 0, 1);
            Assert.Equal(0, count);
            Assert.Empty(roots);
        }

        [Fact]
        public void Solve_ShouldReturnOneRoot_WhenDeltaIsZero()
        {
            var (count, roots) = QuadraticEquation.Solve(1, 2, 1);
            Assert.Equal(1, count);
            Assert.Single(roots);
            Assert.Equal(-1, roots[0], 5);
        }

        [Fact]
        public void Solve_ShouldReturnTwoRoots_WhenDeltaIsPositive()
        {
            var (count, roots) = QuadraticEquation.Solve(1, -5, 6);
            Assert.Equal(2, count);
            Assert.Equal(2, roots.Length);
            var sorted = roots.OrderBy(x => x).ToArray();
            Assert.Equal(2.0, sorted[0], 5);
            Assert.Equal(3.0, sorted[1], 5);
        }

        [Fact]
        public void Solve_ShouldThrowException_WhenAIsZero()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                QuadraticEquation.Solve(0, 1, 1);
            });
        }

        [Fact]
        public void Solve_ShouldReturnZeroRoots_AndUseMultipleAsserts()
        {
            var (count, roots) = QuadraticEquation.Solve(2, 2, 2);
            Assert.Equal(0, count);
            Assert.Empty(roots);
            Assert.False(roots.Any());
            Assert.NotNull(roots);
        }

        [Fact]
        public void Solve_ShouldReturnOneRoot_AndCheckRange()
        {
            var (count, roots) = QuadraticEquation.Solve(1, -4, 4);
            Assert.Equal(1, count);
            Assert.Single(roots);
            Assert.InRange(roots[0], 1.99, 2.01);
        }

        [Fact]
        public void Solve_ShouldReturnTwoRoots_AndCheckContent()
        {
            var (count, roots) = QuadraticEquation.Solve(1, -1, -2);
            Assert.Equal(2, count);
            Assert.Equal(2, roots.Length);
            var sorted = roots.OrderBy(x => x).ToArray();
            Assert.Contains(sorted, val => Math.Abs(val - (-1.0)) < 1e-6);
            Assert.Contains(sorted, val => Math.Abs(val - 2.0) < 1e-6);
            Assert.DoesNotContain(0.0, sorted);
            Assert.True(sorted[0] < 0);
            Assert.True(sorted[1] > 0);
        }
    }