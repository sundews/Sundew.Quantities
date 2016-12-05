namespace Sundew.Quantities.Generator
{
    public interface IGeneratorProgress
    {
        void Project(int projectNumber, int projectsCount);

        void Model(int modelNumber, int modelsCount);
    }
}