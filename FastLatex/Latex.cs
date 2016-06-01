using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
                [$@"\!(\([^\(\)][^\(\)]+\))"] = @"\overline{$1}",
                ["->"] = @"\to",
                ["<-"] = @"\gets"
            };
            var operatorsFromFile = TryToGetFromFile();
            foreach (var latex in operatorsFromFile)
                Operators.Add(latex.From, latex.To);
        }

        private static List<Sublatex> TryToGetFromFile()
        {
            var result = new List<Sublatex>();
            if (File.Exists("additions.fast"))
            {
                var file = File.ReadAllText("additions.fast");
                try
                {
                    result = JsonConvert.DeserializeObject<List<Sublatex>>(file);
                }
                catch (Exception e)
                {
                    File.WriteAllText("log.txt", JsonConvert.SerializeObject(e));
                }

            }
            return result;
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

    internal class Sublatex
    {
        public string From;
        public string To;
        public Sublatex(string from, string to)
        {
            From = from;
            To = to;
        }
    }
}