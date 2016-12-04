using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Newtonsoft.Json;

namespace Sundew.Quantities.Generator
{
    class Program
    {
        static int Main(string[] args)
        {
            string generatorSettingsFilePath = "Quantities.gs.json";
            if (args.Length == 1)
            {
                generatorSettingsFilePath = args[0];
            }

            if (!File.Exists(generatorSettingsFilePath))
            {
                return -1;
            }

            Generate(JsonConvert.DeserializeObject<GeneratorSettings>(File.ReadAllText(generatorSettingsFilePath))).Wait();
            return 0;
        }

        private static async Task Generate(GeneratorSettings generatorSettings)
        {
            var workspace = MSBuildWorkspace.Create();

            foreach (var targetProject in generatorSettings.TargetProjects)
            {
                var project = await workspace.OpenProjectAsync(targetProject);
                foreach (var quantityDefinition in Get(generatorSettings))
                {
                    var classFileName =
                        $"{quantityDefinition.Name}{generatorSettings.OutputFileNameSuffix}{generatorSettings.OutputFileExtension}";
                    var classFilePath = Path.Combine(Path.GetDirectoryName(project.FilePath), generatorSettings.TargetNamespace, classFileName);

                    var document = project.Documents.FirstOrDefault(x => classFilePath.Equals(x.FilePath));
                    if (document != null)
                    {
                        project = project.RemoveDocument(document.Id);
                    }

                    document = project.AddDocument(classFileName, GetClass(classFileName, generatorSettings, project, quantityDefinition), null, classFilePath);
                    project = document.Project;
                }

                if (workspace.TryApplyChanges(project.Solution))
                {

                }
            }

            workspace.CloseSolution();
        }

        private static string GetClass(string classFileName, ICodeGeneratorSettings codeGeneratorSettings, Project project, QuantityDefinition quantityDefinition)
        {
            return QuantityGenerator.Generate(classFileName, codeGeneratorSettings, project, quantityDefinition);
        }

        public static IEnumerable<QuantityDefinition> Get(GeneratorSettings generatorSettings)
        {
            foreach (
                var modelFilePath in
                Directory.EnumerateFiles(generatorSettings.ModelsFolder, generatorSettings.ModelFilesSearchPattern))
            {
                var quantityDefinition =
                    JsonConvert.DeserializeObject<QuantityDefinition>(File.ReadAllText(modelFilePath));
                yield return quantityDefinition;
            }
        }
    }
}
