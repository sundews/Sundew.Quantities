namespace Sundew.Quantities.Generator
{
    using System;

    public class GeneratorString
    {
        private const char IndentChar = ' ';
        private static readonly char[] NewLineChars = Environment.NewLine.ToCharArray();
        private readonly string value;
        private readonly int lineIndent;

        public GeneratorString(string value)
            : this(0, value)
        {
        }

        public GeneratorString(int lineIndent, string value)
        {
            this.value = value;
            this.lineIndent = lineIndent;
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
            if (this.lineIndent > 0)
            {
                var indent = new string(IndentChar, this.lineIndent);
                return
                    this.value.Replace(Environment.NewLine, Environment.NewLine + indent)
                    .Replace(Environment.NewLine + indent + Environment.NewLine, Environment.NewLine + Environment.NewLine)
                        .TrimEnd(IndentChar)
                        .Trim(NewLineChars);
            }

            return this.value.Trim(NewLineChars);
        }
    }
}