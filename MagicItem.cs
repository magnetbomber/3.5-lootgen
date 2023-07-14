namespace LootGenerator_Three_Five;

public interface MagicItemInternal : Treasure
{
    enum Tier
    {
        Mundane,
        Minor,
        Medium,
        Major
    }

    Tier getTier();
}

public class MagicItem : Treasure
{
    MagicItemInternal item;
    private Random rnd = new Random();
    public int value()
    {
        return item.value();
    }

    public MagicItem()
    {
        GenerateNewMagicItem(MagicItemInternal.Tier.Mundane);
    }

    public MagicItem(int tier)
    {
        switch (tier)
        {
            case 1:
                GenerateNewMagicItem(MagicItemInternal.Tier.Minor);
                break;
            case 2:
                GenerateNewMagicItem(MagicItemInternal.Tier.Medium);
                break;
            case 3:
                GenerateNewMagicItem(MagicItemInternal.Tier.Major);
                break;
            default:
                GenerateNewMagicItem(MagicItemInternal.Tier.Mundane);
                break;
        }
    }

    public MagicItem(MagicItemInternal.Tier tier)
    {
        GenerateNewMagicItem(tier);
    }

    private void GenerateNewMagicItem(MagicItemInternal.Tier tier)
    {
        if (tier == MagicItemInternal.Tier.Mundane)
        {
            
        }

        if (tier == MagicItemInternal.Tier.Minor)
        {
            GMinorTable();
        }

        if (tier == MagicItemInternal.Tier.Medium)
        {
            GMediumTable();
        }

        if (tier == MagicItemInternal.Tier.Major)
        {
            GMajorTable();
        }
    }

    private void GMinorTable()
    {
        int d100 = Dr(1, 100);
        if (d100 <= 4)
        {
            item = new Armor();
        }else if (d100 <= 9)
        {
            item = new Weapon();
        }else if (d100 <= 44)
        {
            item = new Potion();
        }else if (d100 <= 46)
        {
            item = new Ring();
        }else if (d100 <= 81)
        {
            item = new Scroll();
        }else if (d100 <= 91)
        {
            item = new Wand();
        }else
        {
            item = new WondrousItem();
        }
        
    }

    private void GMediumTable()
    {
        int d100 = Dr(1, 100);
        if (d100 <= 10)
        {
            item = new Armor();
        }else if (d100 <= 20)
        {
            item = new Weapon();
        }else if (d100 <= 30)
        {
            item = new Potion();
        }else if (d100 <= 40)
        {
            item = new Ring();
        }else if (d100 <= 50)
        {
            item = new Rod();
        }else if (d100 <= 65)
        {
            item = new Scroll();
        }else if (d100 <= 68)
        {
            item = new Staff();
        }else if (d100 <= 83)
        {
            item = new Wand();
        }else
        {
            item = new WondrousItem();
        }
    }

    private void GMajorTable()
    {
        int d100 = Dr(1, 100);
        if (d100 <= 10)
        {
            item = new Armor();
        }else if (d100 <= 20)
        {
            item = new Weapon();
        }else if (d100 <= 25)
        {
            item = new Potion();
        }else if (d100 <= 35)
        {
            item = new Ring();
        }else if (d100 <= 45)
        {
            item = new Rod();
        }else if (d100 <= 55)
        {
            item = new Scroll();
        }else if (d100 <= 75)
        {
            item = new Staff();
        }else if (d100 <= 80)
        {
            item = new Wand();
        }else
        {
            item = new WondrousItem();
        }
    }
    private int Dr(int n, int d)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += rnd.Next(1, d + 1);
        }
        return sum;
    }
}