using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Playnite.SDK;

namespace PlayniteRanks
{
    public partial class PlayniteRanksSettingsView : UserControl
    {
        private PlayniteRanks playniteRanks;

        public PlayniteRanksSettingsView(PlayniteRanks playniteRanks)
        {
            this.playniteRanks = playniteRanks;
            InitializeComponent();
            DataContext = this.playniteRanks.overwatch2Ranks; // Set the data context to the Overwatch2Ranks instance
        }

        private void RankSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Update the selected rank in Overwatch2Ranks
            playniteRanks.overwatch2Ranks.SelectedRank = (Rank)rankComboBox.SelectedItem;
        }
    }
}