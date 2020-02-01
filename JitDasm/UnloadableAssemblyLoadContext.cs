using System.Reflection;
using System.Runtime.Loader;

namespace JitDasm {
    public class UnloadableAssemblyLoadContext : AssemblyLoadContext
    {
        public UnloadableAssemblyLoadContext()
            : base(true)
        {
        }

        protected override Assembly Load(AssemblyName assemblyName) => null!;
    }
}
