using System.Collections.Generic;

namespace Sundew.Quantities.Generator
{
    public class QuantityDefinition
    {
        public QuantityDefinition(string name, IReadOnlyList<string> usings, bool useGlobalUsings, string unitSelector)
        {
            Name = name;
            Usings = usings;
            UseGlobalUsings = useGlobalUsings;
            UnitSelector = unitSelector;
        }

        public string Name { get; }

        public IEnumerable<string> Usings { get; }

        public string UnitSelector { get; }

        public bool UseGlobalUsings { get; }
    }
}