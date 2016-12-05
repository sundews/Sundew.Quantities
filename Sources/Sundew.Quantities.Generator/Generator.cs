// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Generator.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis.MSBuild;
    using Newtonsoft.Json;

    public class Generator<TModelDefinition>
    {
        public async Task Generate(
            IGeneratorSettings generatorSettings,
            IModelGenerator<TModelDefinition> modelGenerator,
            IGeneratorProgress generatorProgress,
            IGeneratorLog generatorLog)
        {
            try
            {
                generatorLog.Log(
                    $"Starting {typeof(TModelDefinition).Name.Replace("Definition", string.Empty)} generator..." +
                    Environment.NewLine);
                var workspace = MSBuildWorkspace.Create();

                var projectNumber = 1;
                foreach (var targetProject in generatorSettings.TargetProjects)
                {
                    generatorLog.Log($"Loading project {targetProject}");
                    generatorProgress.Project(projectNumber++, generatorSettings.TargetProjects.Count);

                    var project = await workspace.OpenProjectAsync(targetProject);
                    var modelNumber = 1;
                    var models = Get(generatorSettings).ToArray();
                    foreach (var modelDefinition in models)
                    {
                        var classFileName = modelGenerator.GetFileName(generatorSettings, modelDefinition);
                        var classFilePath = Path.Combine(Path.GetDirectoryName(project.FilePath),
                            generatorSettings.TargetNamespace, classFileName);

                        var document = project.Documents.FirstOrDefault(x => classFilePath.Equals(x.FilePath));
                        if (document != null)
                        {
                            project = project.RemoveDocument(document.Id);
                        }

                        generatorLog.Log($"Generating: {classFileName}");
                        generatorProgress.Model(modelNumber++, models.Length);

                        document = project.AddDocument(classFileName,
                            modelGenerator.Generate(classFileName, generatorSettings, project, modelDefinition), null,
                            classFilePath);
                        project = document.Project;
                    }

                    generatorLog.Log($"Saving project {targetProject}" + Environment.NewLine);

                    if (workspace.TryApplyChanges(project.Solution))
                    {
                    }
                }

                workspace.CloseSolution();
                generatorLog.Log(
                    $"Completed {typeof(TModelDefinition).Name.Replace("Definition", string.Empty)} generator." +
                    Environment.NewLine);
            }
            catch (Exception exception)
            {
                generatorLog.Log("Error: " + exception);
            }
        }

        public static IEnumerable<TModelDefinition> Get(IGeneratorSettings generatorSettings)
        {
            foreach (
                var modelFilePath in
                Directory.EnumerateFiles(generatorSettings.ModelsFolder, generatorSettings.ModelFilesSearchPattern))
            {
                var quantityDefinition =
                    JsonConvert.DeserializeObject<TModelDefinition>(File.ReadAllText(modelFilePath));
                yield return quantityDefinition;
            }
        }
    }
}