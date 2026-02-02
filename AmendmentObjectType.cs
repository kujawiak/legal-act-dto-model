namespace ModelDto
{
    public enum AmendmentObjectType
    {
        Article,
        Subsection,
        Point,
        Letter,
        Tiret,
        CommonPart, // część wspólna (intro/wrapUp)
        None
    }

    public static class AmendmentObjectTypeExtensions
    {
        public static string ToFriendlyString(this AmendmentObjectType type)
        {
            return type switch
            {
                AmendmentObjectType.Article => "artykul",
                AmendmentObjectType.Subsection => "ustep",
                AmendmentObjectType.Point => "punkt",
                AmendmentObjectType.Letter => "litera",
                AmendmentObjectType.Tiret => "tiret",
                AmendmentObjectType.CommonPart => "czesc_wspólna",
                _ => "none"
            };
        }

        public static string ToStyleValueString(this AmendmentObjectType type)
        {
            return type switch
            {
                AmendmentObjectType.Article => "ART",
                AmendmentObjectType.Subsection => "UST",
                AmendmentObjectType.Point => "PKT",
                AmendmentObjectType.Letter => "LIT",
                AmendmentObjectType.Tiret => "TIR",
                AmendmentObjectType.CommonPart => "CW",
                _ => ""
            };
        }
    }
}