namespace LootGenerator_Three_Five;

public interface MagicalEquipment : MagicItemInternal
{
    int enhancementBonus();
}
public class Armor : MagicalEquipment
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Shield : MagicalEquipment
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Weapon : MagicalEquipment
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Potion : MagicItemInternal
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class Ring : MagicItemInternal
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class Rod : MagicItemInternal
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class Scroll : MagicItemInternal
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class Staff : MagicItemInternal
{
    private int v = 0;
    private int charges = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class Wand : MagicItemInternal
{
    private int v = 0;
    private int charges = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class WondrousItem : MagicItemInternal
{
    private int v = 0;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}