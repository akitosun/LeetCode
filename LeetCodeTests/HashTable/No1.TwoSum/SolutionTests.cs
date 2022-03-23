using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.HashTable.No1.TwoSum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode.HashTable.No1.TwoSum.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        [DataRow(new int[]{ 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSumTest(int[] nums,int target,int[] expected)
        {
            var sut=new Solution();
            var actual = sut.TwoSum(nums, target);
            actual.Should().BeEquivalentTo(expected);
        }
    }
}