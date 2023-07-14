namespace LootGenerator_Three_Five;

public class Hoard
{
    private int cp, sp, gp, pp = 0;
    private Random rnd = new Random();
    public Hoard()
    {
        double cr = 1.0;
        int d = Dr(1,100);
        GenerateCoins(cr, 1.0, d);
        GenerateGems(cr, 1.0, d);
        GenerateItems(cr, 1.0, d);
    }

    public Hoard(double cr)
    {
        int d = Dr(1,100);
        GenerateCoins(cr, 1.0, d);
        GenerateGems(cr, 1.0, d);
        GenerateItems(cr, 1.0, d);
    }

    public Hoard(double cr, double coinMult, double gemMult, double itemMult)
    {
        
        int d = Dr(1,100);
        GenerateCoins(cr, coinMult, d);
        GenerateGems(cr, gemMult, d);
        GenerateItems(cr, itemMult, d);
    }

    private void GenerateCoins(double cr, double coinMult, int d100)
    {
        int roll;
        switch (cr)
        {
            case 1.0:
                if (d100 >= 15 && d100 <= 29)
                {
                    cp = 1000 * Dr(1,6);
                }
                if (d100 >= 30 && d100 <= 52)
                {
                    sp = 100 * Dr(1, 8);
                }
                if (d100 >= 53 && d100 <= 95)
                {
                    gp = 10 * Dr(2, 8);
                }
                if (d100 >= 96)
                {
                    pp = 10 * Dr(1, 4);
                }

                break;
            case 2.0:
                if (d100 >= 14 && d100 <= 23)
                {
                    cp = 1000 * Dr(1,10);
                }
                if (d100 >= 24 && d100 <= 43)
                {
                    sp = 100 * Dr(2, 10);
                }
                if (d100 >= 44 && d100 <= 95)
                {
                    gp = 10 * Dr(4, 10);
                }
                if (d100 >= 96)
                {
                    pp = 10 * Dr(2, 8);
                }

                break;
            case 3.0:
                if (d100 >= 12 && d100 <= 21)
                {
                    cp = 1000 * Dr(2,10);
                }
                if (d100 >= 22 && d100 <= 41)
                {
                    sp = 100 * Dr(4, 8);
                }
                if (d100 >= 42 && d100 <= 95)
                {
                    gp = 100 * Dr(1, 4);
                }
                if (d100 >= 96)
                {
                    pp = 10 * Dr(1, 10);
                }

                break;
            case 4.0:
            case 5.0:
            case 6.0:
            case 7.0:
            case 8.0:
            case 9.0:
            case 10.0:
            case 11.0:
            case 12.0:
            case 13.0:
            case 14.0:
            case 15.0:
            case 16.0:
            case 17.0:
            case 18.0:
            case 19.0:
            case 20.0:
            default:
                break;
        }
    }

    private void GenerateGems(double cr, double gemMult, int d100)
    {
        
    }

    private void GenerateItems(double cr, double itemMult, int d100)
    {
        
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