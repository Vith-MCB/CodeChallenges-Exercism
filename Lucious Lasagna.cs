//This problem is used to learn methods concept

//Lasagna class
public class Lasagna {
    int timeInOven = 40; //Time in minutes that the lasagna should be in the oven

    public static void Main(string[] args)
    {
        Lasagna lasagna = new Lasagna(); //creating new lasagna

        Console.WriteLine("Lasagna needs to stay {0} minutes in the oven.", lasagna.expectedMinutesInOven());
        Console.WriteLine("Remaining time in oven: {0} minutes.", lasagna.remainingMinutesInOven(20));
        Console.WriteLine("Time spent preparing: {0} minutes.", lasagna.preparationTimeInMinutes(2));
        Console.WriteLine("Time spent: {0} minutes.", lasagna.elapsedTimeInMinutes(3, 20));

    }

    /// <summary>
    /// 1) Defining the expect oven time in minutes.
    /// </summary>
    /// <returns>Time that lasagna needs to stay in oven.</returns>
    public int expectedMinutesInOven()
    {
        return timeInOven;
    }

    /// <summary>
    /// 1) Calculates the remaining oven time in minutes.
    /// </summary>
    /// <returns>Remaining time that lasagna needs to stay in oven.</returns>
    public int remainingMinutesInOven(int minutesInOven)
    {
        return timeInOven - minutesInOven;
    }

    /// <summary>
    /// 1) Calculates the preparation time in minutes.
    /// </summary>
    /// <returns>Returns how many minutes you spent prepairing the lasagna, assuming each layer takes you 2 minutes to prepare.</returns>
    public int preparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers * 2;
    }

    /// <summary>
    /// 1) Calculates the preparation time in minutes.
    /// </summary>
    /// <returns>Returns how many minutes you spent prepairing the lasagna, assuming each layer takes you 2 minutes to prepare.</returns>
    public int elapsedTimeInMinutes(int numberOfLayers, int minutesInOven)
    {
        return (numberOfLayers * 2) + minutesInOven;
    }

}