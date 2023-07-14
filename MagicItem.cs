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
            
        }

        if (tier == MagicItemInternal.Tier.Medium)
        {
            
        }

        if (tier == MagicItemInternal.Tier.Major)
        {
            
        }
    }
}