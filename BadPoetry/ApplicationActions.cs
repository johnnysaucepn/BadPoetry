using CLAP;
using Newtonsoft.Json;
using SmartFormat;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace BadPoetry
{
    internal class ApplicationActions
    {
        [Error]
        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Implicitly triggered by CLAP parser")]
        public void Error(ExceptionContext ctx)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ctx.Exception.Message);
            Console.ResetColor();
        }

        [Empty, Help]
        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Implicitly triggered by CLAP parser")]
        public void Help(string helpText)
        {
            Console.WriteLine(helpText);
        }

        /// <summary>
        /// Perform some bad poetry
        /// </summary>
        [Verb(IsDefault = true, Description = "Do some bad poetry")]
        [SuppressMessage("ReSharper", "UnusedMember.Global", Justification = "Implicitly triggered by CLAP parser")]
        public void Poem(
            [Required, Aliases("f")] string[] inputFilenames,
            [DefaultValue(5), Aliases("l")] int lines
            )
        {
            var concatenatedFile = new InputSource();

            var serializerSettings = new JsonSerializerSettings()
            {
                MissingMemberHandling = MissingMemberHandling.Ignore
            };

            foreach (var filename in inputFilenames)
            {
                var path = Path.GetFullPath(filename);
                Console.WriteLine($"Reading source file {path}...");
                var inputFileContent = File.ReadAllText(path);
                var inputFile = JsonConvert.DeserializeObject<InputSource>(inputFileContent, serializerSettings);

                concatenatedFile.Concatenate(inputFile);
            }

            if (!concatenatedFile.IsValid())
            {
                throw new ArgumentException("Not enough content in the files to generate poetry");
            }

            var random = new Random();

            for (var i=0; i<lines; i++)
            {
                var templateIndex = random.Next(concatenatedFile.Templates.Count);

                var template = concatenatedFile.Templates[templateIndex];

                var replacements = new Replacements(concatenatedFile);

                Smart.Default.Settings.CaseSensitivity = SmartFormat.Core.Settings.CaseSensitivityType.CaseInsensitive;
                

                Console.WriteLine(Smart.Format(template, replacements));
            }
        }
    }
}
