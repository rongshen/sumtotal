using System;
using System.Text;
using System.Windows.Forms;

namespace TranslationTool
{
    public partial class MainForm : Form
    {
        private string _gitRepository;
        private string _outputLocation;
        private string _tracebackDays;

        public MainForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var help = new StringBuilder();
            help.Append("1. Put your git application location\n");
            help.Append("2. Set your output file location\n");
            help.Append("3. Set your trace back days\n");
            help.Append("4. Click Start.");
            MessageBox.Show(help.ToString());
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (ValidateParameters())
            {
                startButton.Text = String.Format("Processing");
                TranslationMachine.Start(_gitRepository, _outputLocation, _tracebackDays);
            }
            else
            {
                MessageBox.Show(String.Format("Value cannot be empty!"));
            }
            startButton.Text = String.Format("Start");
        }

        private bool ValidateParameters()
        {
            if (String.IsNullOrEmpty(gitTextBox.Text.Trim()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(outputTextBox.Text.Trim()))
            {
                return false;
            }
            if (String.IsNullOrEmpty(traceBackTextBox.Text.Trim()))
            {
                return false;
            }
            _gitRepository = gitTextBox.Text.Trim();
            _outputLocation = outputTextBox.Text.Trim();
            _tracebackDays = traceBackTextBox.Text.Trim();
            return true;
        }
    }
}
