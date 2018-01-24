using System.Diagnostics.CodeAnalysis;

namespace BadPoetry
{
    public class Word
    {
        private readonly string _word;

        public Word(string word)
        {
            _word = word;
        }

        public override string ToString()
        {
            return _word;
        }

        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Used by formatting specifier")]
        public string Caps()
        {
            return string.Concat(_word[0].ToString().ToUpper(), _word.Substring(1));
        }

    }
}
