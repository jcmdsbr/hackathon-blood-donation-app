namespace StarCastGrupoDois.Infra.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string UnMask(this string value)
        {
            return value.Replace(".", string.Empty).Replace("-", string.Empty);
        }
    }
}
