using System;
using System.ComponentModel;
using System.Reflection;

namespace Panels_And_Forms.Services;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo field = value.GetType().GetField(value.ToString());
        DescriptionAttribute attribute = (DescriptionAttribute)field.GetCustomAttribute(typeof(DescriptionAttribute));
        return attribute != null ? attribute.Description : value.ToString();
    }
}

public enum MyEnum
{
    [Description("Alabama")]
    Alabama,

    [Description("Illinois")]
    Illinois,
}