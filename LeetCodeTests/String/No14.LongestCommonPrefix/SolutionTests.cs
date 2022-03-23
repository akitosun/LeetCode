using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.String.No14.LongestCommonPrefix;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace LeetCode.String.No14.LongestCommonPrefix.Tests
{
    [TestClass()]
    public class SolutionTests
    {
        [TestMethod()]
        [DataRow(new string[]{ "flower", "flow", "flight" },"fl")]
        [DataRow(new string[] { "dog", "racecar", "car" }, "")]
        [DataRow(new string[] { "leets", "leetcode", "leet","leeds" }, "lee")]
        public void HorizontalScanningTest(string[] input,string output)
        {
            var sut = new Solution();
            var actual = sut.LongestCommonPrefixByHorizontalScanning(input);
            actual.Should().BeEquivalentTo(output);
        }
        [TestMethod()]
        [DataRow(new string[] { "flower", "flow", "flight" }, "fl")]
        [DataRow(new string[] { "dog", "racecar", "car" }, "")]
        [DataRow(new string[] { "leets", "leetcode", "leet", "leeds" }, "lee")]
        public void VerticalScanningTest(string[] input, string output)
        {
            var sut = new Solution();
            var actual = sut.LongestCommonPrefixByVerticalScanning(input);
            actual.Should().BeEquivalentTo(output);
        }
    }
}