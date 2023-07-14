namespace LootGenerator_Three_Five;

public interface MagicalEquipment : MagicItemInternal
{
    int enhancementBonus();
}
public class Armor : MagicalEquipment
{
    private int v = 0;
    private MagicItemInternal.Tier tier;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        return tier;
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Shield : MagicalEquipment
{
    private int v = 0;
    private MagicItemInternal.Tier tier;
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
    private MagicItemInternal.Tier tier;
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
    private MagicItemInternal.Tier tier;
    private string spell;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return "Potion of " + spell + " (" + value + " gp)";
    }
}
public class Ring : MagicItemInternal
{
    private int v = 0;
    private MagicItemInternal.Tier tier;
    private string name;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return "Ring of " + name + " (" + value + " gp)";
    }
}
public class Rod : MagicItemInternal
{
    private int v = 0;
    private MagicItemInternal.Tier tier;
    private string name;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return "Rod of " + name + " (" + value + " gp)";
    }
}
public class Scroll : MagicItemInternal
{
    private int v = 0;
    private MagicItemInternal.Tier tier;
    private string scrollType;
    private string[] spells;
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
    private MagicItemInternal.Tier tier;
    private string name;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return "Staff of " + name + " [" + charges + "/50 charges] (" + value + " gp)";
    }
}
public class Wand : MagicItemInternal
{
    private int v = 0;
    private int charges = 0;
    private MagicItemInternal.Tier tier;
    private string spell;
    public int value()
    {
        return v;
    }

    public override string ToString()
    {
        return "Wand of " + spell + " [" + charges + "/50 charges] (" + value + " gp)";
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
}
public class WondrousItem : MagicItemInternal
{
    private int v = 0;
    private MagicItemInternal.Tier tier;
    private string name;
    public int value()
    {
        return v;
    }

    public MagicItemInternal.Tier getTier()
    {
        throw new NotImplementedException();
    }
    public override string ToString()
    {
        return name + " (" + value + " gp)";
    }
}