using System;
using System.Collections.Generic;
using System.Text;

namespace SOLUTIONS.GALAXY.Domain.Extensions
{
    public static class EnumExtensions
    {
        public static T ToEnum<T>(this string value) where T : struct
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
