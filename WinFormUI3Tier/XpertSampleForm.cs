
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using XpertStudio.Common.Data;
using XpertStudio.Framework.WinFormUI;

namespace WinFormUI3Tier
{
    public partial class XpertSampleForm : XpertBaseForm
    {
        public XpertSampleForm()
        {
            InitializeComponent();
        }


        //public static async Task<bool> IsBooleanExpression(string expression)
        //{
        //    try
        //    {
        //        var result = await CSharpScript.EvaluateAsync(expression, ScriptOptions.Default);
        //        return result is bool;
        //    }
        //    catch (CompilationErrorException)
        //    {
        //        return false;
        //    }
        //}

        //private static readonly string booleanPattern = @"^(\s*(!?\s*[A-Za-z_]\w*(\.[A-Za-z_]\w*)*\s*(==|!=|<=|>=|<|>|\|\||&&)\s*)*!?\s*[A-Za-z_]\w*(\.[A-Za-z_]\w*)*\s*)+$";


        //public static bool IsBooleanExpression(string expression)
        //{
        //    var res= Regex.IsMatch(expression, booleanPattern);
        //    return res;
        //}

        private void xpertFinder1__MYValidating(object sender, EventArgs e, bool isButtonClicked)
        {
            //if ( IsBooleanExpression("(Model.Amount==Model.Document_Amount) || (Model.Amot!=Model.testAmt) && (Model.Doc_amt>0)"))
            //{
            //    MessageBox.Show("Ok");
            //}
            checkExpressions();
        }
        private static readonly Regex tokenRegex = new Regex(@"(?<identifier>[A-Za-z_]\w*(\.[A-Za-z_]\w*)*)|(?<operator>\|\||&&|==|!=|<=|>=|<|>)|(?<parenthesis>[()])|(?<literal>\d+|true|false)|(?<whitespace>\s+)", RegexOptions.Compiled);
        public static bool IsBooleanExpression(string expression)
        {
            var tokens = Tokenize(expression);
            return ParseExpression(tokens);
        }
        private static List<string> Tokenize(string expression)
        {
            var matches = tokenRegex.Matches(expression);
            var tokens = new List<string>();

            foreach (Match match in matches)
            {
                if (!string.IsNullOrEmpty(match.Groups["identifier"].Value))
                    tokens.Add(match.Groups["identifier"].Value);
                else if (!string.IsNullOrEmpty(match.Groups["operator"].Value))
                    tokens.Add(match.Groups["operator"].Value);
                else if (!string.IsNullOrEmpty(match.Groups["parenthesis"].Value))
                    tokens.Add(match.Groups["parenthesis"].Value);
                else if (!string.IsNullOrEmpty(match.Groups["literal"].Value))
                    tokens.Add(match.Groups["literal"].Value);
            }

            return tokens;
        }
        private static bool ParseExpression(List<string> tokens)
        {
            Stack<string> stack = new Stack<string>();
            bool expectOperand = true;

            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];

                if (token == "(")
                {
                    stack.Push(token);
                    expectOperand = true;
                }
                else if (token == ")")
                {
                    if (stack.Count == 0 || stack.Peek() != "(")
                        return false;

                    stack.Pop();
                    expectOperand = false;
                }
                else if (IsOperator(token))
                {
                    if (expectOperand)
                        return false;

                    expectOperand = true;
                }
                else // identifier or literal
                {
                    if (!expectOperand)
                        return false;

                    expectOperand = false;
                }
            }

            return stack.Count == 0 && !expectOperand;
        }
        private static bool IsOperator(string token)
        {
            return token == "||" || token == "&&" || token == "==" || token == "!=" || token == "<=" || token == ">=" || token == "<" || token == ">";
        }
        public static void checkExpressions()
        {
            string[] expressions = {
            "true && false",
            "Model.Document_Amount>0",
            "Model.Amount == Model.Document_Amount",
            "5 + 3",
            "!Model.Amount == Model.Document_Amount",
            "(Model.Amount==Model.Document_Amount) || (Model.Amot!=Model.testAmt) && (Model.Doc_amt>0)"
        };

            foreach (var expression in expressions)
            {
                bool isValid = IsBooleanExpression(expression);
                MessageBox.Show($"Is '{expression}' a valid boolean expression? {isValid}");
            }
        }
    }
}
