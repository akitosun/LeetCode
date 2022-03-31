using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Array.No._1337.The_K_Weakest_Rows_in_a_Matrix.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        
        public void KWeakestRowsTest()
        {
            var mat = new[] {new[]{ 1, 1, 0, 0, 0 },new[]{ 1, 1, 1, 1, 0 }, new[] { 1, 0, 0, 0, 0 }, new[]{ 1, 1, 0, 0, 0 }, new[] { 1, 1, 1, 1, 1 } };
            var expected = new[] {2, 0, 3};
            var k = 3;
            var sut = new Solution();
            var actual = sut.KWeakestRows(mat, k);
            Console.WriteLine(actual);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}