public struct PlayerHealth
{
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    public bool IsAlive { get; set; }
    public string PlayerName { get; set; }
    public List<StatusEffect> ActiveEffects { get; set; }
}

public readonly struct DamageInfo
{
    public int Amount { get; }
    public DamageType Type { get; }
    public Vector3 HitPoint { get; }

    public DamageInfo(int amount, DamageType type, Vector3 hitPoint)
    {
        Amount = amount;
        Type = type;
        HitPoint = hitPoint;
    }
}

public class Color32Data
{
    public byte R;
    public byte G;
    public byte B;
    public byte A;
}

public struct GameSettings
{
    public float MasterVolume { get; set; }
    public float MusicVolume { get; set; }
    public float SFXVolume { get; set; }
    public int ResolutionWidth { get; set; }
    public int ResolutionHeight { get; set; }
    public bool IsFullscreen { get; set; }
    public string Language { get; set; }
    public Dictionary<string, KeyCode> KeyBindings { get; set; }
}

public class EntityId
{
    public int Value { get; }

    public EntityId(int value)
    {
        Value = value;
    }
}

public readonly struct BulletData
{
    public float Speed { get; }
    public int Damage { get; }
    public float Lifetime { get; }
    public byte BulletType { get; }

    public BulletData(float speed, int damage, float lifetime, byte bulletType)
    {
        Speed = speed;
        Damage = damage;
        Lifetime = lifetime;
        BulletType = bulletType;
    }
}

public struct InventoryItem
{
    public byte SlotIndex;
    public long ItemId;
    public byte Quantity;
    public int Durability;
    public bool IsEquipped;
}
