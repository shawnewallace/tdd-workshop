// Replace %CODE% with requested id, and %ALTCODE% with "dashed" version of id.
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace RefactoringExample
{
    public class CodeReplacer
    {
        public String SourceTemplate { get; set; }
        
        String _code;
        String _altcode;

        public void Substitute(String reqId, TextWriter output)
        {
            // Read in the template file
            StringBuilder sb = new StringBuilder("");

            try
            {
                Assembly _assembly = Assembly.GetExecutingAssembly();
                StreamReader sr = new StreamReader(_assembly.GetManifestResourceStream("RefactoringExample.template.html"));
                String line;
                while (((line = sr.ReadLine()) != "") && (line != null))
                    sb = new StringBuilder(sb + line + "\n");
                sr.Close();
            }
            catch (Exception e)
            {
            }
            SourceTemplate = sb.ToString();

            try
            {
                String template = (string)SourceTemplate.Clone();
                // Substitute for %CODE%
                int templateSplitBegin = template.IndexOf("%CODE%");
                int templateSplitEnd = templateSplitBegin + 6;
                String templatePartOne = template.Substring(0, templateSplitBegin);
                String templatePartTwo = template.Substring(templateSplitEnd, template.Length - 1);
                _code = reqId.ToString();
                template = templatePartOne + _code + templatePartTwo;

                // Substitute for %ALTCODE%
                templateSplitBegin = template.IndexOf("%ALTCODE%");
                templateSplitEnd = templateSplitBegin + 9;
                templatePartOne = template.Substring(0, templateSplitBegin);
                templatePartTwo = template.Substring(templateSplitEnd, template.Length - 1);
                _altcode = _code.Substring(0, 4) + "-" + _code.Substring(4, 4);
                output.Write(templatePartOne + _altcode + templatePartTwo);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in substitute()");
            }

            output.Flush();
            output.Close();
        }
    }
}