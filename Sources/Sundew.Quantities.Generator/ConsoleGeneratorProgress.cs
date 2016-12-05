namespace Sundew.Quantities.Generator
{
    using System;

    public class ConsoleGeneratorProgress : IGeneratorProgress
    {
        public void Project(int projectNumber, int projectsCount)
        {
            Console.WriteLine($" - {projectNumber} / {projectsCount}");
        }

        public void Model(int modelNumber, int modelsCount)
        {
            Console.WriteLine($" - {modelNumber} / {modelsCount}");
        }
    }
}