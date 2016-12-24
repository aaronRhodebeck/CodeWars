using System;
public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        var tower = new string[nFloors];
        var totalWidthOfTower = (nFloors * 2) - 1;
        for (int i = 0; i < nFloors; i++)
        {
            string floor = "";
            tower[i] = floor.PadLeft(i, ' ')
                        .PadRight(totalWidthOfTower - i, '*')
                        .PadRight(totalWidthOfTower, ' ');
        }
        Array.Reverse(tower);
        return tower;
    }
}