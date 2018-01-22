using System.Collections.Generic;
using System.Linq;

namespace BadPoetry
{
    public class InputSource
    {
        public List<string> Templates { get; set; } = new List<string>();
        public List<string> Verbs { get; set; } = new List<string>();
        public List<string> Nouns { get; set; } = new List<string>();
        public List<string> Adjectives { get; set; } = new List<string>();
        public List<string> Adverbs { get; set; } = new List<string>();
        public List<string> Articles { get; set; } = new List<string>();

        internal void Concatenate(InputSource inputFile)
        {
            Templates.AddRange(inputFile.Templates);
            Verbs.AddRange(inputFile.Verbs);
            Nouns.AddRange(inputFile.Nouns);
            Adjectives.AddRange(inputFile.Adjectives);
            Adverbs.AddRange(inputFile.Adverbs);
            Articles.AddRange(inputFile.Articles);
        }

        public bool IsValid()
        {
            return Templates.Any() && Verbs.Any() && Nouns.Any() && Adjectives.Any() && Adverbs.Any() && Articles.Any();
        }

    }
}
