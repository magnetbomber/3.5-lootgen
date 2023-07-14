using System;

namespace LootGenerator_Three_Five;

public class Gem : Treasure
{
    private int v;
    private string desc;
    private Random rnd = new Random();
    private string[] _tier5gems = {"clearest bright green emerald","blue-white diamond","canary diamond","pink diamond","brown diamond","blue diamond","jacinth"};
    private string[] _tier4gems = {"emerald","white opal","black opal","fire opal","blue sapphire","fiery yellow corundum","rich purple corundum","blue star sapphire","black star sapphire","star ruby"};
    private string[] _tier3gems = {"alexandrite","aquamarine","violet garnet","black pearl","deep blue spinel","golden yellow topaz"};
    private string[] _tier2gems = {"amber","amethyst","chrysoberyl","coral","red garnet","brown-green garnet","jade","jet","white pearl","golden pearl","pink pearl","silver pearl","red spinel","red-brown spinel","deep green spinel","tourmaline"};
    private string[] _tier1gems = {"bloodstone","carnelian","chalcedony","chrysoprase","citrine","iolite","jasper","moonstone","onyx","peridot","clear quartz","sard","sardonyx","rose quartz","smoky quartz","star rose quartz","zircon"};
    private string[] _tier0gems = {"banded agate","eye agate","moss agate","azurite","blue quartz","hematite","lapis lazuli","malachite","obsidian","rhodochrosite","tiger eye turquoise","freshwater pearl"};

    public Gem()
    {
        int tier = generateTier();
        desc = generateDesc(tier);
        v = generateValue(tier);
    }
    public int value()
    {
        return v;
    }
    
    public override string ToString()
    {
        return desc + " (" + value() + " gp)";
    }

    private string generateDesc(int tier)
    {
        string output = "";
        int i = 0;
        switch (tier)
        {
            case 0:
                i = rnd.Next(0, _tier0gems.Length);
                output = _tier0gems[i];
                break;
            case 1:
                i = rnd.Next(0, _tier1gems.Length);
                output = _tier1gems[i];
                break;
            case 2:
                i = rnd.Next(0, _tier2gems.Length);
                output = _tier2gems[i];
                break;
            case 3:
                i = rnd.Next(0, _tier3gems.Length);
                output = _tier3gems[i];
                break;
            case 4:
                i = rnd.Next(0, _tier4gems.Length);
                output = _tier4gems[i];
                break;
            case 5:
                i = rnd.Next(0, _tier5gems.Length);
                output = _tier5gems[i];
                break;
            default:
                output = "gem";
                break;
        }
        return output;
    }

    private int generateValue(int tier)
    {
        int val = 0;
        switch (tier)
        {
            case 0:
                val = Dr(4, 4);
                break;
            case 1:
                val = 10 * Dr(2, 4);
                break;
            case 2:
                val = 10 * Dr(4, 4);
                break;
            case 3:
                val = 100 * Dr(2, 4);
                break;
            case 4:
                val = 100 * Dr(4, 4);
                break;
            case 5:
                val = 1000 * Dr(2, 4);
                break;
            default:
                break;
        }

        return val;
    }

    private int generateTier()
    {
        int d100 = Dr(1, 100);
        if (d100 <= 25)
        {
            return 0;
        }

        if (d100 <= 50)
        {
            return 1;
        }

        if (d100 <= 70)
        {
            return 2;
        }

        if (d100 <= 90)
        {
            return 3;
        }

        if (d100 <= 99)
        {
            return 4;
        }

        return 5;
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

public class Art : Treasure
{
    private int v;
    private string desc;
    private Random rnd = new Random();

    public Art()
    {
        int tier = generateTier();
        desc = generateDesc(tier);
        v = generateValue(tier);
    }
    public int value()
    {
        return v;
    }

    public override string ToString()
    {
        return desc + " (" + value() + " gp)";
    }
    
    private string generateDesc(int tier)
    {
        return "art";
    }

    private int generateValue(int tier)
    {
        int val = 0;
        switch (tier)
        {
            case 0:
                val = 10 * Dr(1, 10);
                break;
            case 1:
                val = 10 * Dr(3, 6);
                break;
            case 2:
                val = 100 * Dr(1, 6);
                break;
            case 3:
                val = 100 * Dr(1, 10);
                break;
            case 4:
                val = 100 * Dr(2, 6);
                break;
            case 5:
                val = 100 * Dr(3, 6);
                break;
            case 6:
                val = 100 * Dr(4, 6);
                break;
            case 7:
                val = 100 * Dr(5, 6);
                break;
            case 8:
                val = 1000 * Dr(1, 4);
                break;
            case 9:
                val = 1000 * Dr(1, 6);
                break;
            case 10:
                val = 1000 * Dr(2, 4);
                break;
            case 11:
                val = 1000 * Dr(2, 6);
                break;
            default:
                break;
        }

        return val;
    }
    private int generateTier()
    {
        int d100 = Dr(1, 100);
        if (d100 <= 10)
        {
            return 0;
        }

        if (d100 <= 25)
        {
            return 1;
        }

        if (d100 <= 40)
        {
            return 2;
        }

        if (d100 <= 50)
        {
            return 3;
        }

        if (d100 <= 60)
        {
            return 4;
        }

        if (d100 <= 70)
        {
            return 5;
        }

        if (d100 <= 80)
        {
            return 6;
        }

        if (d100 <= 85)
        {
            return 7;
        }

        if (d100 <= 90)
        {
            return 8;
        }

        if (d100 <= 95)
        {
            return 9;
        }

        if (d100 <= 99)
        {
            return 10;
        }

        return 11;
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