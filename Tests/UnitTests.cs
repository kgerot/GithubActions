﻿using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        public void Power_Valid()
        {
            Assert.AreEqual(1, Program.Add("1", "10"));
            Assert.AreEqual(36, Program.Add("6", "2"));
            Assert.AreEqual(125, Program.Add("5", "3"));
        }

        [TestMethod]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "zero"));
            Assert.Throws<FormatException>(() => Program.Add("twelve", "1"));
            Assert.Throws<FormatException>(() => Program.Add("zero",  "zero"));
        }

        [TestMethod]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("5", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "55"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }
    }
}
