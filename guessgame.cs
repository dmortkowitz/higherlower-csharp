using System;

class NumberGame {
    private int minNumber = 1;
    private int maxNumber = 101;

    private int RandomNumber(int min, int max)
    {
      Random number = new Random();
      return number.Next(min, max);
    }

    public int GuessNum;
    public int newNumber;

    public void InitializeGame()
    {
      GuessNum = RandomNumber(minNumber, maxNumber);
      newNumber = GuessNum;
    }

  public void NumberFinder (string answer) {
    if (answer == "lower") {
        maxNumber = newNumber;
        newNumber = RandomNumber(minNumber, maxNumber);
    } else if (answer == "higher"){
        minNumber = newNumber;
        newNumber = RandomNumber(minNumber, maxNumber);
    }
  }
}

public class GuessingGame
{
  public static void Main()
  {
    NumberGame myNumber = new NumberGame();
    myNumber.InitializeGame();
    Console.WriteLine("Would you like to play the higher/lower game? (yes/no)");
  string input = Console.ReadLine();

    if(input == "yes")
    {
    Console.WriteLine ("Okay!");
  }
  else{
    Console.WriteLine("GoodBye");
  }
    Console.WriteLine("Is your number higher or lower than " +myNumber.newNumber+ "? (higher/lower/correct)");
    string answer = Console.ReadLine();
    myNumber.NumberFinder(answer);
    if(answer == "correct")
    {
      Console.WriteLine("Correct answer!");
    }
    else{
      while(answer!= "correct")
      {
        Console.WriteLine("Is your number higher or lower than " + myNumber.newNumber + "? (higher/lower/correct)");
        answer = Console.ReadLine ();
        myNumber.NumberFinder(answer);

      }
    }
  }
}
