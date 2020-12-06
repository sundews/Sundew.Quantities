// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityModel.cs" company="Hukano">
// Copyright (c) Hukano. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Sundew.Quantities.Generator
{
    using Sundew.Base.Text;
    using Sundew.Generator;
    using Sundew.Generator.Code;
    using Sundew.Generator.Discovery;
    using Sundew.Generator.Input;
    using Sundew.Generator.Output;
    using Sundew.Quantities.Generator.Quantities;
    using Sundew.Quantities.Generator.UnitSelectors;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class Setup : ISetupsFactory
    {
        public Task<IEnumerable<ISetup>> GetSetupsAsync()
        {
            return Task.FromResult(
                (IEnumerable<ISetup>)new ISetup[] {
                new CodeSetup {
                    ModelSetup = new FolderModelSetup
                    {
                        Folder = "../../../Models",
                        FilesSearchPattern = "*.json",
                    },
                    WriterSetups = new[]
                    {
                        new FileWriterSetup("../../../../Sundew.Quantities/Sundew.Quantities.csproj")
                        {
                            Writer = new ProjectTextFileWriter(),
                            FileExtension = ".cs",
                            FileNameSuffix = ".g",
                            Folder = ".g",
                        },
                    },
                    TargetNamespace = "UnitSelectors",
                    UseGlobalUsings = true,
                    Usings = new [] { "System.CodeDom.Compiler" },
                    GeneratorSetups = new []
                    {
                        new CodeGeneratorSetup
                        {
                            Generator = new UnitSelectorGenerator(),
                            Usings = new []
                            {
                                "System.Collections.Generic",
                                "Sundew.Quantities.Representations.Units",
                                "Sundew.Quantities.Representations.Expressions",
                                "Sundew.Quantities.UnitSelection"
                            },
                        },
                        new CodeGeneratorSetup
                        {
                            Generator = new UnitSelectorInterfaceGenerator(),
                            Usings = new []
                            {
                                "Sundew.Quantities.Representations.Units",
                                "Sundew.Quantities.Representations.Expressions",
                                "Sundew.Quantities.UnitSelection"
                            },
                        },
                        new CodeGeneratorSetup
                        {
                            Generator = new PrefixedUnitSelectorInterfaceGenerator(),
                            Usings = new [] { "Sundew.Quantities.UnitSelection" },
                        },
                        new CodeGeneratorSetup
                        {
                            Generator = new QuantityGenerator(),
                            TargetNamespace = Strings.Empty,
                            Usings = new []
                            {
                                "System",
                                "System.Globalization",
                                "Sundew.Quantities.Core",
                                "Sundew.Quantities.Representations.Expressions",
                                "Sundew.Quantities.UnitSelectors"
                            },
                        },
                    }
            } });
        }
    }
}