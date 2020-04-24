using System;
using System.ComponentModel;

namespace NetExtensions.ExtensionMethods
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum @enum)
        {
            var attribute = @enum.GetAttributeOfType<DescriptionAttribute>();
            return attribute == null ? @enum.ToString() : attribute.Description;
        }

        public static bool HasDescription(this Enum @enum)
        {
            return @enum.GetAttributeOfType<DescriptionAttribute>() != null;
        }

        #region PrivateMethods

        private static T GetAttributeOfType<T>(this Enum enumVal) where T : Attribute
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            if (memInfo.Length == 0)
                return null;
            var attributes = memInfo[0].GetCustomAttributes(typeof(T), false);
            if (attributes.Length == 0)
                return null;
            return (T)attributes[0];
        }

        #endregion
    }
}