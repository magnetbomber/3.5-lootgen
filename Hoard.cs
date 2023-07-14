using System.Collections;

namespace LootGenerator_Three_Five;

public class Hoard
{
    private int cp, sp, gp, pp = 0;
    private Random rnd = new Random();
    private ArrayList stash = new ArrayList();
    public Hoard()
    {
        double cr = 1.0;
        int d = Dr(1,100);
        GenerateCoins(cr, 1.0, d);
        d = Dr(1,100);
        GenerateTreasures(cr, 1.0, d);
        d = Dr(1,100);
        GenerateItems(cr, 1.0, d);
    }

    public Hoard(double cr)
    {
        int d = Dr(1,100);
        GenerateCoins(cr, 1.0, d);
        d = Dr(1,100);
        GenerateTreasures(cr, 1.0, d);
        d = Dr(1,100);
        GenerateItems(cr, 1.0, d);
    }

    public Hoard(double cr, double coinMult, double gemMult, double itemMult)
    {
        
        int d = Dr(1,100);
        GenerateCoins(cr, coinMult, d);
        d = Dr(1,100);
        GenerateTreasures(cr, gemMult, d);
        d = Dr(1,100);
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
                if (d100 >= 12 && d100 <= 21)
                {
                    cp = 1000 * Dr(3,10);
                }
                if (d100 >= 22 && d100 <= 41)
                {
                    sp = 1000 * Dr(4, 12);
                }
                if (d100 >= 42 && d100 <= 95)
                {
                    gp = 100 * Dr(1, 6);
                }
                if (d100 >= 96)
                {
                    pp = 10 * Dr(1, 8);
                }

                break;
            case 5.0:
                if (d100 >= 11 && d100 <= 19)
                {
                    cp = 10000 * Dr(1,4);
                }
                if (d100 >= 20 && d100 <= 38)
                {
                    sp = 1000 * Dr(1, 6);
                }
                if (d100 >= 39 && d100 <= 95)
                {
                    gp = 100 * Dr(1, 8);
                }
                if (d100 >= 96)
                {
                    pp = 10 * Dr(1, 10);
                }

                break;
            case 6.0:
                if (d100 >= 11 && d100 <= 18)
                {
                    cp = 10000 * Dr(1,6);
                }
                if (d100 >= 19 && d100 <= 37)
                {
                    sp = 1000 * Dr(1, 8);
                }
                if (d100 >= 38 && d100 <= 95)
                {
                    gp = 100 * Dr(1, 10);
                }
                if (d100 >= 96)
                {
                    pp = 10 * Dr(1, 12);
                }

                break;
            case 7.0:
                if (d100 >= 12 && d100 <= 18)
                {
                    cp = 10000 * Dr(1,10);
                }
                if (d100 >= 19 && d100 <= 35)
                {
                    sp = 1000 * Dr(1, 12);
                }
                if (d100 >= 36 && d100 <= 93)
                {
                    gp = 100 * Dr(2, 6);
                }
                if (d100 >= 94)
                {
                    pp = 10 * Dr(3, 4);
                }

                break;
            case 8.0:
                if (d100 >= 11 && d100 <= 15)
                {
                    cp = 10000 * Dr(1,12);
                }
                if (d100 >= 16 && d100 <= 29)
                {
                    sp = 1000 * Dr(2, 6);
                }
                if (d100 >= 30 && d100 <= 87)
                {
                    gp = 100 * Dr(2, 8);
                }
                if (d100 >= 88)
                {
                    pp = 10 * Dr(3, 6);
                }

                break;
            case 9.0:
                if (d100 >= 11 && d100 <= 15)
                {
                    cp = 10000 * Dr(2,6);
                }
                if (d100 >= 16 && d100 <= 29)
                {
                    sp = 1000 * Dr(2, 8);
                }
                if (d100 >= 30 && d100 <= 85)
                {
                    gp = 100 * Dr(5, 4);
                }
                if (d100 >= 86)
                {
                    pp = 10 * Dr(2, 12);
                }

                break;
            case 10.0:
                if (d100 >= 11 && d100 <= 24)
                {
                    sp = 1000 * Dr(2, 10);
                }
                if (d100 >= 25 && d100 <= 79)
                {
                    gp = 100 * Dr(6, 4);
                }
                if (d100 >= 80)
                {
                    pp = 10 * Dr(5, 6);
                }

                break;
            case 11.0:
                if (d100 >= 9 && d100 <= 14)
                {
                    sp = 1000 * Dr(3, 10);
                }
                if (d100 >= 15 && d100 <= 75)
                {
                    gp = 100 * Dr(4, 8);
                }
                if (d100 >= 76)
                {
                    pp = 10 * Dr(4, 10);
                }

                break;
            case 12.0:
                if (d100 >= 9 && d100 <= 14)
                {
                    sp = 1000 * Dr(3, 12);
                }
                if (d100 >= 15 && d100 <= 75)
                {
                    gp = 1000 * Dr(1, 4);
                }
                if (d100 >= 76)
                {
                    pp = 100 * Dr(1, 4);
                }

                break;
            case 13.0:
                if (d100 >= 9 && d100 <= 75)
                {
                    gp = 1000 * Dr(1, 4);
                }
                if (d100 >= 76)
                {
                    pp = 100 * Dr(1, 10);
                }

                break;
            case 14.0:
                if (d100 >= 9 && d100 <= 75)
                {
                    gp = 1000 * Dr(1, 6);
                }
                if (d100 >= 76)
                {
                    pp = 100 * Dr(1, 12);
                }

                break;
            case 15.0:
                if (d100 >= 4 && d100 <= 74)
                {
                    gp = 1000 * Dr(1, 8);
                }
                if (d100 >= 75)
                {
                    pp = 100 * Dr(3, 4);
                }

                break;
            case 16.0:
                if (d100 >= 4 && d100 <= 74)
                {
                    gp = 1000 * Dr(1, 12);
                }
                if (d100 >= 75)
                {
                    pp = 100 * Dr(3, 4);
                }

                break;
            case 17.0:
                if (d100 >= 4 && d100 <= 68)
                {
                    gp = 1000 * Dr(3, 4);
                }
                if (d100 >= 69)
                {
                    pp = 100 * Dr(2, 10);
                }

                break;
            case 18.0:
                if (d100 >= 3 && d100 <= 65)
                {
                    gp = 1000 * Dr(3, 6);
                }
                if (d100 >= 66)
                {
                    pp = 100 * Dr(5, 4);
                }

                break;
            case 19.0:
                if (d100 >= 3 && d100 <= 65)
                {
                    gp = 1000 * Dr(3, 8);
                }
                if (d100 >= 66)
                {
                    pp = 100 * Dr(3, 10);
                }

                break;
            case 20.0:
                if (d100 >= 3 && d100 <= 65)
                {
                    gp = 1000 * Dr(4, 8);
                }
                if (d100 >= 66)
                {
                    pp = 100 * Dr(4, 10);
                }

                break;
            default:
                break;
        }

        cp = (int)(coinMult * cp);
        sp = (int)(coinMult * sp);
        gp = (int)(coinMult * gp);
        pp = (int)(coinMult * pp);
    }

    private void GenerateTreasures(double cr, double gemMult, int d100)
    {
        int gemloop = 0, artloop = 0;
        switch (cr)
        {
            case 1.0:
                if (d100 >= 91 && d100 <= 95)
                {
                    gemloop = (int)gemMult;
                }

                if (d100 >= 96)
                {
                    artloop = (int)gemMult;
                }

                break;
            case 2.0:
                if (d100 >= 82 && d100 <= 95)
                {
                    gemloop = (int)gemMult * Dr(1,3);
                }

                if (d100 >= 96)
                {
                    artloop = (int)gemMult * Dr(1,3);
                }

                break;
            default:
                break;
        }

        if (gemloop > 0)
        {
            for (int i = 0; i < gemloop; i++)
            {
                stash.Add(new Gem());
            }
        }
        if (artloop > 0)
        {
            for (int i = 0; i < artloop; i++)
            {
                stash.Add(new Art());
            }
        }
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

    public override string ToString()
    {
        string output = "";
        output += "Coins:";
        if (cp != 0)
        {
            output += " " + cp + " cp.";
        }

        if (sp != 0)
        {
            output += " " + sp + " sp.";
        }

        if (gp != 0)
        {
            output += " " + gp + " gp.";
        }

        if (pp != 0)
        {
            output += " " + pp + " pp.";
        }

        output += "\nItems:";
        foreach (var item in stash)
        {
            output += " " + item.ToString + ",";
        }

        return output;
    }
}