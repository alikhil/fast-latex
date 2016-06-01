using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FastLatex
{
    internal class Latex
    {
        private string Value = "";
        private static Dictionary<string, string> Operators;
        private bool ParagraphBorders = false;
        static Latex()
        {
            Operators = new Dictionary<string, string>()
            {
                [$"({Regex.Escape("*")})"] = "\\cdot",
                [$@"\!(\w)"] = @"\bar{$1}",
                [$@"\!(\([^\(][^\(]+\))"] = @"\overline{$1}"
            };
        }

        public Latex(string latexText)
        {
            Value = latexText;
        }

        public Latex(string latex, bool par):
            this(latex)
        {
            ParagraphBorders = par;
        }
        public Latex()
        {

        }

        internal static Latex GetFromText(string text)
        {
            var newStr = ReplaceOperators(text);

            return new Latex(newStr);
        }

        internal Latex SetParagraph(bool par)
        {
            return new Latex(Value, par);
        }

        internal static string ReplaceOperators(string text)
        {
            string newText = text;
            foreach (var item in Operators)
            {
                newText = Regex.Replace(newText, $"{item.Key}", item.Value);
            }
            return newText;
        }

        internal string Build()
        {
            return SetIntoBorders(Value);
        }

        private string SetIntoBorders(string value)
        {
            if (ParagraphBorders)
                return $"[mathjax]{value}[/mathjax]";
            else
                return $"\\({value}\\)"; 
        }

        
    }
}