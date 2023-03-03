using System;

public class Player
{
    public int RollDie()
    {
        Random RandNumbGen = new Random();
        return RandNumbGen.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        Random RandNumbGen = new Random();
        return (RandNumbGen.NextDouble())*100;
    }
}
