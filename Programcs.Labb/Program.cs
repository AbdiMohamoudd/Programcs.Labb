using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ange en textsträng:");
        string userInput = Console.ReadLine();

        List<(string sequence, int startIndex)> validSequences = new List<(string, int)>();

        for (int i = 0; i < userInput.Length; i++) 
        {
            if (Char.IsDigit(userInput[i]))
            {
                var startDigit = userInput[i];
                var startIndex = i;

                var currentSequence = startDigit.ToString();

                for(int j = i + 1; j < userInput.Length; j++)
                {
                   if(char.IsDigit(userInput[j]))
                    {
                        currentSequence += userInput[j];
                        if (userInput[j] == startDigit)
                        {
                            validSequences.Add((currentSequence, startIndex));
                            break;
                        }
                    }
                    else
                    {
                        currentSequence = "";
                        break;
                    }
                }
            }
        }
        long totalSum = 0;
        Console.WriteLine("Sekvenser:");
        foreach (var sequence in validSequences) 
        {
            Console.Write(userInput.Substring(0, sequence.startIndex));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(userInput.Substring(sequence.startIndex, sequence.sequence.Length));
            Console.ResetColor();
            Console.Write(userInput.Substring(sequence.startIndex + sequence.sequence.Length));
            Console.WriteLine();

            var number = long.Parse(sequence.sequence.ToString());
            totalSum += number;
        }

        Console.WriteLine("Total summa: " + totalSum);

       
    }
}