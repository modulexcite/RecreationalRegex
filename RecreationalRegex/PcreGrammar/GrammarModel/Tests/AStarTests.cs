﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kobi.RecreationalRegex.PcreGrammar.GrammarModel.Tests
{
    [TestFixture]
    public class AStarTests
    {
        private readonly Regex _aStar;

        public AStarTests()
        {
            _aStar = ExampleLanguages.AStar().ToRegex();
        }

        [TestCase("a")]
        [TestCase("aaaaa")]
        [TestCase("aa")]
        [TestCase("")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")]
        public void ShouldMatch(string word)
        {
            Assert.That(_aStar.IsMatch(word));
        }

        [TestCase("aaax")]
        [TestCase("aaxaaa")]
        [TestCase("aaaaaaaaaaaaax")]
        [TestCase("ddddd")]
        public void ShouldNotMatch(string word)
        {
            Assert.That(_aStar.IsMatch(word), Is.False);
        }
    }
}
