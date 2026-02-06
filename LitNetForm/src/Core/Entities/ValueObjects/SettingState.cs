namespace Core.Entities.ValueObjects;

public sealed record SettingState
{
    public bool Enabled { get; private set; }
    
    public int Order { get; private set; }

    public SettingState(bool enabled, int order)
    {
        Enabled = enabled;
        Order = order;
    }
};