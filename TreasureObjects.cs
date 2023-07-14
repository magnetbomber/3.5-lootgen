namespace LootGenerator_Three_Five;

public class Gem : Treasure
{
    private int v;
    private string desc;
    private Random rnd = new Random();

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
        return "gem";
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