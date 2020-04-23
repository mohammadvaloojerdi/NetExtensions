using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NetExtensions.PrimitiveExtensions
{
    public static class AssemblyExtensions
    {
        public static IEnumerable<Type> GetClassesThatImplements<T>(this Assembly assembly)
        {
            return assembly.GetTypes()
                .Where(type =>
                    !type.IsInterface && !type.IsAbstract && type != typeof(T) && typeof(T).IsAssignableFrom(type));
        }

        public static IEnumerable<Type> GetSubClassesOf<T>(this Assembly assembly)
        {
            return assembly.GetTypes().Where(type => !type.IsAbstract && type.IsSubclassOf(typeof(T)));
        }
    }
}