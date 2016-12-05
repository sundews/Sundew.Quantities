namespace Sundew.Quantities.Generator
{
    using Microsoft.CodeAnalysis;

    public interface IModelGenerator<in TModelDefinition>
    {
        string GetFileName(IGeneratorSettings generatorSettings, TModelDefinition modelDefinition);

        GeneratorString Generate(string classFileName, IGeneratorSettings generatorSettings, Project project, TModelDefinition modelDefinition);
    }
}