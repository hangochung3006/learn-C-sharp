static class Badge
{
    public static string Print(int? id, string name, string? department) {
        string dep = department?.ToUpper() ?? "OWNER";
        return (id == null) ? $"{name} - {dep}" : $"[{id}] - {name} - {dep}";
    }
}
