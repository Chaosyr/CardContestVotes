using Cecil_Libraries.ANSI_Utils.Lists;
using Cecil_Libraries.ANSI_Utils.Objects;

namespace CardContestVotes;

public class Class1
{
    public static void Main(String[] args)
    {
        Color red = new Color("Underlined", "Red");
        bool running = true;
        Dictionary<string, (int firstPlace, int secondPlace, int thirdPlace, int coolnessPoints)> entries = new Dictionary<string, (int firstPlace, int secondPlace, int thirdPlace, int coolnessPoints)>();
        while (running)
        {
            try
            {
                Console.WriteLine(red.Format() + "Please enter the Participant Name:" + red.GetReset().Format());
                string participant = Console.ReadLine();
                Console.WriteLine(red.Format() + "Please enter the Total First Place Votes:" + red.GetReset().Format());
                int firstPlace = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(red.Format() + "Please enter the Total Second Place Votes:" +
                                  red.GetReset().Format());
                int secondPlace = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(red.Format() + "Please enter the Total Third Place Votes:" + red.GetReset().Format());
                int thirdPlace = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(red.Format() + "Please enter the Total Coolness Place Votes:" +
                                  red.GetReset().Format());
                int coolPlace = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(red.Format() + "Are you done entering?" + red.GetReset().Format());
                bool finality = Convert.ToBoolean(Console.ReadLine());
                if (finality)
                {
                    running = false;
                }

                entries.Add(participant, new(firstPlace, secondPlace, thirdPlace, coolPlace));
            }
            catch
            {
                Console.WriteLine("You mixed up the form inputs should be sent it, so we are gracefully catching it, please retry your last entry!");
                Console.WriteLine("Place Votes, should be a integer, meaning no decimal points or fractions!");
                Console.WriteLine("When you answer the Are You Done, we expect a True or a False as the answer.");
                Console.ReadLine();
            }
        }

        foreach (KeyValuePair<string, (int firstPlace, int secondPlace, int thirdPlace, int coolnessPoints)> entry in entries)
        {
            Console.WriteLine($"Total Points for {entry.Key}: " + ((entry.Value.firstPlace * 3) + (entry.Value.secondPlace * 2) + entry.Value.thirdPlace) + ".");
            Console.WriteLine($"Coolness Points for {entry.Key}: " + entry.Value.coolnessPoints + ".");
            Console.WriteLine(ANSICodeLists.ResetColor);
            Console.ReadLine();
        }
    }
}