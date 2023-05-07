using SplatoonFanGame;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SplatoonFanGame2
{
    public partial class MainWindow : Window
    {
        private Game _game;
        private Agent _selectedAgent;
        private Button _selectedAgentButton;

        public MainWindow()
        {
            InitializeComponent();
            _game = new Game();






        }

        private void AgentButton_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedAgentButton != null)
            {
                _selectedAgentButton.BorderThickness = new Thickness(1);
                _selectedAgentButton.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }

            _selectedAgentButton = sender as Button;
            _selectedAgentButton.BorderThickness = new Thickness(3);
            _selectedAgentButton.BorderBrush = new SolidColorBrush(Colors.LightBlue);

            string selectedAgentName = _selectedAgentButton.Content.ToString();
            

            switch (selectedAgentName)
            {
                case "Agent 3":
                    _selectedAgent = new AgentOne();
                    break;
                case "Agent 4":
                    _selectedAgent = new AgentTwo();
                    break;
                case "Agent 8":
                    _selectedAgent = new AgentThree();
                    break;
            }

            StartGameButton.IsEnabled = true;
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            _game.ChooseAgent(_selectedAgent);
            MessageBox.Show($"Starting the game with {_selectedAgentButton.Content}.");

            // Open the DialogueWindow and close the MainWindow
            DialogueWindow dialogueWindow = new DialogueWindow(_selectedAgent);
            dialogueWindow.Show();
            this.Close();
        }
    }

}
