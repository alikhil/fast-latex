using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FastLatex
{
    [TestFixture]
    class Latex_should
    {
    	[TestCase("A * B", @"A \cdot B")]
    	[TestCase("A + B", "A + B")]
        [TestCase("A * B * C", @"A \cdot B \cdot C")]
        [TestCase("A * !B", @"A \cdot \bar{B}")]
        public void replace_operators(string given, string result)
    	{
    		// Arrange
    		var text = given;
    		// Act
    		var newText = Latex.ReplaceOperators(text);
    		// Assert
    		Assert.AreEqual(result, newText);
    	}

    	[TestCase("A * B", "\\(A \\cdot B\\)")]
    	[TestCase("!A", @"\(\bar{A}\)")]
        public void give_latex_from_text(string given, string result)
    	{
    		// Arrange
			var text = given;
    		
    		// Act
			var latex = Latex.GetFromText(text).Build();
    		// Assert
			Assert.AreEqual(result, latex);
    	}
        [Test]
        public void build()
        {
            var latexText = "A + B";

            var latex = new Latex(latexText).Build();

            Assert.AreEqual("\\(A + B\\)", latex);
        }

    }
}
