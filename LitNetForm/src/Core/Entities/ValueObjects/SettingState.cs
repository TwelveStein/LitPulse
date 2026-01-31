namespace Core.Entities.ValueObjects;

public record SettingState
{
    public bool Enabled { get; set; }
    
    public int Order { get; set; }
};