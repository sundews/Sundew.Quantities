namespace Sundew.Quantities.Generator
{
    using System.Collections.Generic;

    public interface IGeneratorSettings : ICodeGeneratorSettings
    {
        string ModelsFolder { get; }

        string ModelFilesSearchPattern { get; }

        string OutputFileExtension { get; }

        string OutputFileNameSuffix { get; }

        IReadOnlyList<string> TargetProjects { get; }
    }
}