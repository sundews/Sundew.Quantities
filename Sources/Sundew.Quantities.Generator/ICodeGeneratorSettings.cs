using System.Collections.Generic;

namespace Sundew.Quantities.Generator
{
    public interface ICodeGeneratorSettings
    {
        string TargetNamespace { get; set; }
        IEnumerable<string> Usings { get; set; }
        bool UseGlobalUsings { get; set; }
    }
}