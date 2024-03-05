using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operations.Infrastructure.ExtensionMethods
{
    public static class EnumExtensionMethod
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue
                .GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()?
                .Name;
        }
    }
}
