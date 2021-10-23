using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class PluginLoader
    {
        private static readonly string PluginPath = Path.Combine("D:\\5 семестр\\СПП\\2\\Faker\\Main\\bin\\Debug\\net5.0", "plugins");
        private Dictionary<Type, IGenerator> generators;

        public PluginLoader(Dictionary<Type, IGenerator> gen)
        {
            this.generators = gen;
        }

        public void LoadPluginGenerators()
        {
            //Console.WriteLine("11111111111111");
            Console.WriteLine(PluginPath);
            if (!Directory.Exists(PluginPath))
                return;
            //Console.WriteLine("2222222222222222");

            string[] files = Directory.GetFiles(PluginPath, "*.dll");
            //Console.WriteLine(PluginPath);

            foreach (var file in files)
            {
                //Console.WriteLine("111"+file);
                Assembly assembly = Assembly.LoadFrom(file);
                LoadPluginGenerator(assembly);
            }
        }

        private void LoadPluginGenerator(Assembly plugin)
        {
            Type generatorType = plugin.GetTypes().FirstOrDefault(type => typeof(IGenerator).IsAssignableFrom(type));

            if (generatorType == null)
                return;

            if (generatorType.FullName == null)
                return;

            if (!generatorType.IsClass)
                return;

            if (plugin.CreateInstance(generatorType.FullName) is IGenerator generatorPlugin)
            {
                this.generators.Add(generatorPlugin.GeneratorType, generatorPlugin);
            }
        }
    }
}
