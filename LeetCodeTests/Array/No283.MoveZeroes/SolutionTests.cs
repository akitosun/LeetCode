using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Array.No283.MoveZeroes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode.Array.No283.MoveZeroes.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        [DataRow(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
        public void MoveZeroesTest(int[] input,int[] output)
        {
            var sut=new Solution();
            var assert = input;
            sut.MoveZeroes(assert);
            assert.Should().BeEquivalentTo(output);
            //Assert.AreEqual(output, assert);
            
        }
    }
}