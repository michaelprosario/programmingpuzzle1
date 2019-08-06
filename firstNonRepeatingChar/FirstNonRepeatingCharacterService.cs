using System.Collections.Generic;
using System.Linq;

namespace firstNonRepeatingChar
{
    public class FirstNonRepeatingCharacterService
    {
        public string Execute(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var characterFrequency = new Dictionary<char, int>();
            var possibleAnswers = new List<string>();

            foreach (char character in input)
            {
                if (characterFrequency.ContainsKey(character))
                {
                    characterFrequency[character] = characterFrequency[character] + 1;
                }
                else
                {
                    characterFrequency[character] = 1;
                }
            }

            foreach (var key in characterFrequency.Keys)
            {
                if (characterFrequency[key] == 1)
                {
                    possibleAnswers.Add(key + "");
                }
            }

            if (possibleAnswers.Count > 0)
            {
                return possibleAnswers.First();
            }
            else
            {
                return null;
            }
        }
    }
}
