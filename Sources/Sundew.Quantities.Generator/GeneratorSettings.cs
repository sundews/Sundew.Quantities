namespace Sundew.Quantities.Generator
{
    using System.Collections.Generic;

    public class GeneratorSettings : IGeneratorSettings
    {
        public GeneratorSettings(string modelsFolder, string modelFilesSearchPattern, string outputFileExtension, string outputFileNameSuffix, IReadOnlyList<string> targetProjects, string targetNamespace, IReadOnlyList<string> usings, bool useGlobalUsings)
        {
            this.ModelsFolder = modelsFolder;
            this.ModelFilesSearchPattern = modelFilesSearchPattern;
            this.OutputFileExtension = outputFileExtension;
            this.OutputFileNameSuffix = outputFileNameSuffix;
            this.TargetProjects = targetProjects;
            this.TargetNamespace = targetNamespace;
            this.Usings = usings;
            this.UseGlobalUsings = useGlobalUsings;
        }

        public string ModelsFolder { get; }

        public string ModelFilesSearchPattern { get; }

        public string OutputFileExtension { get; }

        public string OutputFileNameSuffix { get; }

        public IReadOnlyList<string> TargetProjects { get; }

        public string TargetNamespace { get; }

        public IReadOnlyList<string> Usings { get; }

        public bool UseGlobalUsings { get; }
    }
}
