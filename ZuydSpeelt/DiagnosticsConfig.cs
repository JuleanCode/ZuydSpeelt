using System.Diagnostics;

public static class DiagnosticsConfig
{
    public const string ServiceName = "ZuydSpeeltWebAPI";
    public static ActivitySource ActivitySource = new ActivitySource(ServiceName);
}