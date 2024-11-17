
//Q3
// Converted the main method to Main.
// Added the missing if condition (otherwise).
//The if condition without the bracket has a syntactic mistake.

public class Score
{
    public static void main(String[] args)
    {
        double score = 40;
        if (score > 40)
        {
            Console.WriteLine("You passed the exam!");
        }
        else if (score < 40)
        {
            Console.WriteLine("You failed the exam!");
        }
    }
}
