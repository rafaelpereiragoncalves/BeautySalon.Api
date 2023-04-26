namespace BeautySalon.Crosscutting.Extensions;

public class AppSettings
{
    public string? Secret { get; set; }
    public int ExpireHour { get; set; }
    public string? Issuer { get; set; }
    public string? ValidIn { get; set; }
}
