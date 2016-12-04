using System.Collections.Generic;

namespace Sundew.Quantities.Generator
{
    public interface IGeneratorSettings : ICodeGeneratorSettings
    {
        string ModelsFolder { get; set; }
        string ModelFilesSearchPattern { get; set; }
        string OutputFileExtension { get; set; }
        string OutputFileNameSuffix { get; set; }
        IEnumerable<string> TargetProjects { get; set; }
    }
}