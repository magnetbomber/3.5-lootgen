namespace LootGenerator_Three_Five;


public class Armor : MagicItemInternal
{
    public int value()
    {
        return v;
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Shield : MagicItemInternal
{
    public int value()
    {
        return v;
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Weapon : MagicItemInternal
{
    public int value()
    {
        return v;
    }

    public int enhancementBonus()
    {
        return 0;
    }
}
public class Potion : MagicItemInternal
{
    private string spell;
    public int value()
    {
        return v;
    }
    public override string ToString()
    {
        return "Potion of " + spell + " (" + value + " gp)";
    }
}
public class Ring : MagicItemInternal
{
    private string name;
    public int value()
    {
        return v;
    }
    public override string ToString()
    {
        return "Ring of " + name + " (" + value + " gp)";
    }
}
public class Rod : MagicItemInternal
{
    private string name;
    public int value()
    {
        return v;
    }

    public override string ToString()
    {
        return "Rod of " + name + " (" + value + " gp)";
    }
}
public class Scroll : MagicItemInternal
{
    private string scrollType;
    private string[] spells;
    public int value()
    {
        return v;
    }
}
public class Staff : MagicItemInternal
{
    private int charges = 0;
    private string name;
    public int value()
    {
        return v;
    }
    public override string ToString()
    {
        return "Staff of " + name + " [" + charges + "/50 charges] (" + value + " gp)";
    }
}
public class Wand : MagicItemInternal
{
    private int charges = 0;
    private string spell;
    public int value()
    {
        return v;
    }

    public override string ToString()
    {
        return "Wand of " + spell + " [" + charges + "/50 charges] (" + value + " gp)";
    }
}
public class WondrousItem : MagicItemInternal
{
    private string name;
    public int value()
    {
        return v;
    }
    public override string ToString()
    {
        return name + " (" + value + " gp)";
    }
}