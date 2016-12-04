using System;

namespace Sundew.Quantities.Generator
{
    public class GeneratorString
    {
        private const char IndentChar = ' ';
        private static readonly char[] NewLineChars = Environment.NewLine.ToCharArray();
        private readonly string _value;
        private readonly int _lineIndent;

        public GeneratorString(string value)
            : this(0, value)
        {
        }

        public GeneratorString(int lineIndent, string value)
        {
            _value = value;
            _lineIndent = lineIndent;
        }

        public static  implicit operator string(GeneratorString generatorString)
        {
            return generatorString.ToString();
        }

        public static implicit operator GeneratorString(string value)
        {
            return new GeneratorString(value);
        }

        public override string ToString()
        {
            if (_lineIndent > 0)
            {
                var indent = new string(IndentChar, _lineIndent);
                return
                    _value.Replace(Environment.NewLine, Environment.NewLine + indent)
                    .Replace(Environment.NewLine + indent + Environment.NewLine, Environment.NewLine + Environment.NewLine)
                        .TrimEnd(IndentChar)
                        .Trim(NewLineChars);
            }

            return _value.Trim(NewLineChars);
            /* var result = _value;
             if (result.StartsWith(Environment.NewLine))
             {
                 result = result.Remove(0, 2);
             }
 
             if (result.EndsWith(Environment.NewLine))
             {
                 result = result.Remove(result.Length - 2, 2);
             }
 
             return result;*/
        }
    }
}