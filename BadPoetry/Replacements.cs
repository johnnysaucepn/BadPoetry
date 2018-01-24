using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BadPoetry
{
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global", Justification = "Used by formatting specifier")]
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global", Justification = "Used by formatting specifier")]
    internal class Replacements
    {
        public Word Noun1 { get; }
        public Word Noun2 { get; }
        public Word Noun3 { get; }

        public Word Verb1 { get; }
        public Word Verb2 { get; }
        public Word Verb3 { get; }

        public Word Adjective1 { get; }
        public Word Adjective2 { get; }
        public Word Adjective3 { get; }

        public Word Adverb1 { get; }
        public Word Adverb2 { get; }
        public Word Adverb3 { get; }

        public Word Article1 { get; }
        public Word Article2 { get; }
        public Word Article3 { get; }

        public Replacements(InputSource choices, Random random = null)
        {
            random = random ?? new Random();

            var nouns = choices.Nouns.Select(x => new Word(x)).ToList();
            var verbs = choices.Verbs.Select(x => new Word(x)).ToList();
            var adjectives = choices.Adjectives.Select(x => new Word(x)).ToList();
            var adverbs = choices.Adverbs.Select(x => new Word(x)).ToList();
            var articles = choices.Articles.Select(x => new Word(x)).ToList();

            Noun1 = nouns[random.Next(nouns.Count)];
            Noun2 = nouns[random.Next(nouns.Count)];
            Noun3 = nouns[random.Next(nouns.Count)];

            Verb1 = verbs[random.Next(verbs.Count)];
            Verb2 = verbs[random.Next(verbs.Count)];
            Verb3 = verbs[random.Next(verbs.Count)];

            Adjective1 = adjectives[random.Next(adjectives.Count)];
            Adjective2 = adjectives[random.Next(adjectives.Count)];
            Adjective3 = adjectives[random.Next(adjectives.Count)];

            Adverb1 = adverbs[random.Next(adverbs.Count)];
            Adverb2 = adverbs[random.Next(adverbs.Count)];
            Adverb3 = adverbs[random.Next(adverbs.Count)];

            Article1 = articles[random.Next(articles.Count)];
            Article2 = articles[random.Next(articles.Count)];
            Article3 = articles[random.Next(articles.Count)];
        }
    }
}