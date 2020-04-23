namespace NetExtensions.PrimitiveExtensions
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this object obj)
        {
            return !obj.IsNull();
        }

        public static bool Is<T>(this object obj)
        {
            return obj is T;
        }
    }
}