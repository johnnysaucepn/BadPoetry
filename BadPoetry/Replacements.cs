using System;

namespace BadPoetry
{
    internal class Replacements
    {
        public string Noun1 { get; set; }
        public string Noun2 { get; set; }
        public string Noun3 { get; set; }

        public string Verb1 { get; set; }
        public string Verb2 { get; set; }
        public string Verb3 { get; set; }

        public string Adjective1 { get; set; }
        public string Adjective2 { get; set; }
        public string Adjective3 { get; set; }

        public string Adverb1 { get; set; }
        public string Adverb2 { get; set; }
        public string Adverb3 { get; set; }

        
        public Replacements(InputSource choices, Random random = null)
        {
            random = random ?? new Random();

            Noun1 = choices.Nouns[random.Next(choices.Nouns.Count)];
            Noun2 = choices.Nouns[random.Next(choices.Nouns.Count)];
            Noun3 = choices.Nouns[random.Next(choices.Nouns.Count)];

            Verb1 = choices.Verbs[random.Next(choices.Verbs.Count)];
            Verb2 = choices.Verbs[random.Next(choices.Verbs.Count)];
            Verb3 = choices.Verbs[random.Next(choices.Verbs.Count)];

            Adjective1 = choices.Adjectives[random.Next(choices.Adjectives.Count)];
            Adjective2 = choices.Adjectives[random.Next(choices.Adjectives.Count)];
            Adjective3 = choices.Adjectives[random.Next(choices.Adjectives.Count)];

            Adverb1 = choices.Adverbs[random.Next(choices.Adverbs.Count)];
            Adverb2 = choices.Adverbs[random.Next(choices.Adverbs.Count)];
            Adverb3 = choices.Adverbs[random.Next(choices.Adverbs.Count)];
        }
    }
}