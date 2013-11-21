using System;

namespace AutoParse
{
    public static class AutoParse
    {
        public delegate bool TryParser<T>(string str, out T value);
        public static T TryParse<T>(this string value, TryParser<T> parser)
        {
            T val;
            parser.Invoke(value, out val);
            return val;
        }

        public static T? TryParseNullable<T>(string value, TryParser<T> parser)
            where T : struct
        {
            T val;
            return parser.Invoke(value, out val) ? val : null as T?;
        }
    }
}