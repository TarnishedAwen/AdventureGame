using SplatoonFanGame;
using System.Windows;
using System.Windows.Media;

namespace SplatoonFanGame2
{
    public partial class DialogueWindow : Window
    {
        public DialogueWindow(Agent selectedAgent)
        {
            InitializeComponent();

            string dialogueText = $"Welcome, {selectedAgent.Name}! Let's get ready for some action!";
            DialogueText.Text = dialogueText;
            DialogueText.Foreground = new SolidColorBrush(selectedAgent.Color);
        }

        public DialogueWindow() : this(null)
        {
        }



    }


}
