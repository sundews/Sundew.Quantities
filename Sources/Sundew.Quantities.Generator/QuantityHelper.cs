namespace Sundew.Quantities.Generator
{
    using System;

    public class QuantityHelper
    {
        public static string GetOperator(Operator @operator)
        {
            switch (@operator)
            {
                case Operator.Division:
                    return "/";
                case Operator.Multiplication:
                    return "*";
                default:
                    throw new NotSupportedException("Unknown operator");
            }
        }

        public static string GetOperation(Operator @operator)
        {
            switch (@operator)
            {
                case Operator.Division:
                    return "Divide";
                case Operator.Multiplication:
                    return "Multiply";
                default:
                    throw new NotSupportedException("Unknown operator");
            }
        }

    }
}