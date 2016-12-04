using System.Collections.Generic;

namespace Sundew.Quantities.Generator
{
    public class GeneratorSettings : IGeneratorSettings
    {
        public string ModelsFolder { get; set; }

        public string ModelFilesSearchPattern { get; set; }

        public string OutputFileExtension { get; set; }

        public string OutputFileNameSuffix { get; set; }

        public IEnumerable<string> TargetProjects { get; set; }

        public string TargetNamespace { get; set; }

        public IEnumerable<string> Usings { get; set; }

        public bool UseGlobalUsings { get; set; }
    }
}
