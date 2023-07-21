using Framework.Exceptions;
using System.Reflection;

namespace Framework.Assemblies
{
    public static class AssemblyHelper
    {
        public static Assembly GetAssemblyByNamespace(string targetNamespace)
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var types = assembly.GetTypes();
                if (types.Any(t => t.Namespace == targetNamespace))
                {
                    return assembly;
                }
            }

            Console.WriteLine($"Failed to load the assembly: {targetNamespace}");
            throw new AssemblyLoadException($"Failed to load the assembly: {targetNamespace}");
        }
    }
}
