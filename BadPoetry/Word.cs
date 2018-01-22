using System;
using System.Collections.Generic;
using System.Text;

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

        public string ToCaps()
        {
            return string.Concat(_word[0].ToString().ToUpper(), _word.Substring(1));
        }

    }
}
