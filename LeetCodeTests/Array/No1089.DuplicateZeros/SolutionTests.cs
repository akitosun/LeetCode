using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Array.No1089.DuplicateZeros;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode.Array.No1089.DuplicateZeros.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        [DataRow(new int[] { 1, 0, 2, 3, 0, 4, 5, 0 }, new int[] { 1, 0, 0, 2, 3, 0, 0, 4 })]
        public void DuplicateZerosTest(int[] input, int[] target)
        {
            var array = input;
            var sut=new Solution();
            sut.DuplicateZeros(array);
            array.Should().BeEquivalentTo(target);
        }
    }
}