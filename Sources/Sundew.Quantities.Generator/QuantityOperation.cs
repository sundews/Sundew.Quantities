namespace Sundew.Quantities.Generator
{
    public class QuantityOperation
    {
        public QuantityOperation(Operator @operator, string lhs, string rhs, string result)
        {
            Operator = @operator;
            Lhs = lhs;
            Rhs = rhs;
            Result = result;
        }

        public Operator Operator { get; }

        public string Lhs { get; }

        public string Rhs { get; }

        public string Result { get; }
    }
}