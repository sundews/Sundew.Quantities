namespace Sundew.Quantities.Generator
{
    using System.Collections.Generic;

    public interface ICodeGeneratorSettings
    {
        string TargetNamespace { get; }

        IReadOnlyList<string> Usings { get; }

        bool UseGlobalUsings { get; }
    }
}