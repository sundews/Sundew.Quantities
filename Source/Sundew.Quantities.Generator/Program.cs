using Sundew.Base.Text;

namespace Sundew.Quantities.Generator
{
    using Sundew.Generator;
    using System.Threading.Tasks;
    using Sundew.Generator.Code;
    using Sundew.Generator.Input;
    using Sundew.Generator.Output;
    using Sundew.Quantities.Generator.Quantities;
    using Sundew.Quantities.Generator.UnitSelectors;

    public static class Program
    {
        public static Task Main()
        {
            return GeneratorFacade.RunAsync(new CodeSetup
            {
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
                            Folder = ".generated",
                        },
                    },
                TargetNamespace = "UnitSelectors",
                UseGlobalUsings = true,
                Usings = new[] { "System.CodeDom.Compiler" },
                GeneratorSetups = new[]
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
            });
        }
    }
}
