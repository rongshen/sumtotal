using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TranslationTool
{
    public class TranslationMachine
    {
        private static List<string> _storePhrases;
        private static List<string> _ticketNumbers;
        private static readonly StringBuilder csvBuilder = new StringBuilder();
        private static string _traceBackDays;
        private static string _outputLocation;

        public static void Start(string gitRepository, string outputLocation, string traceBackDays)
        {
            try
            {
                c3poProcess();
                _storePhrases = GetPhrases();
                _traceBackDays = traceBackDays;
                _outputLocation = outputLocation;
                csvBuilder.Append("Ticket List :");
                csvBuilder.Append("\r\n");

                var gitInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true,
                    FileName = gitRepository,
                    WorkingDirectory = @"C:\maestro5\maestro"
                };

                if (_storePhrases.Any())
                {
                    _ticketNumbers = new List<string>();

                    foreach (var storePhrase in _storePhrases)
                    {
                        var gitProcess = new Process { StartInfo = gitInfo };

                        var command1 = "log -1 -S" + "\"" + storePhrase + "\"";
                        var command2 = "log -1 -S" + "\"" + "\\" + "\"" + storePhrase + "\\" + "\"" + "\""; //xhtml
                        var command3 = "log -1 -G" + "\"" + storePhrase + "\"";
                        var phraseList = new List<string> { command1, command2, command3 };

                        FindPhrasesInAllFormats(phraseList, gitProcess, storePhrase);
                    }
                    WriteToFile();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Error In Process"), e.Message);
            }
        }

        public static void FindPhrasesInAllFormats(List<string> phraseList, Process gitProcess, string storePhrase)
        {
            var bingo = false;
            foreach (var phrase in phraseList)
            {
                bingo = FindAndDisplayTicketNumber(gitProcess, phrase);
                gitProcess.WaitForExit();
                gitProcess.Close();
                if (bingo)
                {
                    break;
                }
            }
            if (!bingo)
            {
                csvBuilder.Append("The following phrase is not commited in this release:" + storePhrase);
            }
        }

        public static bool FindAndDisplayTicketNumber(Process gitProcess, string storePhrase)
        {
            gitProcess.StartInfo.Arguments = storePhrase + " --since==" + "\"" + _traceBackDays + "days ago\"" + "--pretty=format:\"%s\"";
            gitProcess.Start();
            return Output(gitProcess);
        }

        public static List<string> GetPhrases()
        {
            var doc = new XmlDocument();

            try
            {
                doc.Load(@"C:\maestro5\maestro\ExternalTools\LocalizationParser\DeltaPackage\Master.xml");
            }
            catch (FileNotFoundException)
            {
                throw new FileNotFoundException("Error load file");
            }

            var storePhrases = new List<string>();
            if (doc.DocumentElement != null)
            {
                var nl = doc.DocumentElement.SelectNodes("//name");

                storePhrases.AddRange(from XmlNode n in nl select n.FirstChild.Value);
                return storePhrases;
            }
            return new List<string>();
        }

        private static bool Output(Process gitProcess)
        {
            var error = gitProcess.StandardError.ReadToEnd();
            if (string.IsNullOrEmpty(error))
            {
                return DisplayResults(gitProcess);
            }
            throw new Exception("git command error:" + error);
        }

        public static bool DisplayResults(Process gitProcess)
        {
            var lineVal = gitProcess.StandardOutput.ReadLine();
            var foundString = false;
            while (lineVal != null)
            {
                if (lineVal.Contains("MST"))
                {
                    foundString = true;
                    var ticketNumber = lineVal.Split(' ')[4];
                    if (!_ticketNumbers.Contains(ticketNumber))
                    {
                        _ticketNumbers.Add(ticketNumber);
                        csvBuilder.AppendLine(lineVal);
                    }
                }
                lineVal = gitProcess.StandardOutput.ReadLine();
            }
            return foundString;
        }

        private static void c3poProcess()
        {
            var translationInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                FileName = @"C:\maestro5\maestro\ExternalTools\LocalizationParser\c3po\bin\c3po.exe",
                WorkingDirectory = @"C:\maestro5\maestro\ExternalTools\LocalizationParser\c3po\bin"
            };

            var translationProcess = new Process { StartInfo = translationInfo };
            string[] args = { " -r", " -c", " -d" };
            translationProcess.StartInfo.Arguments = string.Join(" ", args);
            translationProcess.Start();
            translationProcess.Close();
        }

        private static void WriteToFile()
        {
            using (var outfile = new StreamWriter(_outputLocation))
            {
                outfile.Write(csvBuilder.ToString());
            }
            MessageBox.Show(String.Format("Jira Tickets Numbers have already written to the destination."));
        }
    }
}
