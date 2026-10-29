using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseDemo.Application.Common.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNotNullOrEmptyEx(this string? value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static bool IsNullOrWhiteSpaceEx(this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static string ToNormalizedString(this string? value)
        {
            return value?.Trim() ?? string.Empty;
        }
    }
}
