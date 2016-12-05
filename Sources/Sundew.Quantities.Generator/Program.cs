namespace Sundew.Quantities.Generator
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

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
            Console.ReadKey();
            return 0;
        }

        private static async Task Generate(GeneratorSettings generatorSettings)
        {
            var generator = new Generator<QuantityDefinition>();
            await generator.Generate(generatorSettings, new QuantityGenerator(), new ConsoleGeneratorProgress(), new ConsoleGeneratorLogger());
        }
    }
}
