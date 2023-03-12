using Playnite.SDK;
using Playnite.SDK.Events;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PlayniteRanks
{
    public class PlayniteRanks : GenericPlugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        private PlayniteRanksSettingsViewModel settings { get; set; }

        public override Guid Id { get; } = Guid.Parse("c6782fff-023b-49a9-ab27-cfb3ecb8070c");

        public PlayniteRanks(IPlayniteAPI api) : base(api)
        {
            settings = new PlayniteRanksSettingsViewModel(this);
            Properties = new GenericPluginProperties
            {
                HasSettings = true
            };
        }

        public void InitialiseOverwatch2()
        {
            Game overwatch2 = new Game("Overwatch 2");

            Rank bronze5 = new Rank("Bronze 5", overwatch2);
            Rank bronze4 = new Rank("Bronze 4", overwatch2);
            Rank bronze3 = new Rank("Bronze 3", overwatch2);
            Rank bronze2 = new Rank("Bronze 2", overwatch2);
            Rank bronze1 = new Rank("Bronze 1", overwatch2);

            Rank silver5 = new Rank("Silver 5", overwatch2);
            Rank silver4 = new Rank("Silver 4", overwatch2);
            Rank silver3 = new Rank("Silver 3", overwatch2);
            Rank silver2 = new Rank("Silver 2", overwatch2);
            Rank silver1 = new Rank("Silver 1", overwatch2);

            Rank gold5 = new Rank("Gold 5", overwatch2);
            Rank gold4 = new Rank("Gold 4", overwatch2);
            Rank gold3 = new Rank("Gold 3", overwatch2);
            Rank gold2 = new Rank("Gold 2", overwatch2);
            Rank gold1 = new Rank("Gold 1", overwatch2);

            Rank platinum5 = new Rank("Platinum 5", overwatch2);
            Rank platinum4 = new Rank("Platinum 4", overwatch2);
            Rank platinum3 = new Rank("Platinum 3", overwatch2);
            Rank platinum2 = new Rank("Platinum 2", overwatch2);
            Rank platinum1 = new Rank("Platinum 1", overwatch2);

            Rank diamond5 = new Rank("Diamond 5", overwatch2);
            Rank diamond4 = new Rank("Diamond 4", overwatch2);
            Rank diamond3 = new Rank("Diamond 3", overwatch2);
            Rank diamond2 = new Rank("Diamond 2", overwatch2);
            Rank diamond1 = new Rank("Diamond 1", overwatch2);

            Rank master5 = new Rank("Master 5", overwatch2);
            Rank master4 = new Rank("Master 4", overwatch2);
            Rank master3 = new Rank("Master 3", overwatch2);
            Rank master2 = new Rank("Master 2", overwatch2);
            Rank master1 = new Rank("Master 1", overwatch2);

            Rank grandmaster5 = new Rank("Grandmaster 5", overwatch2);
            Rank grandmaster4 = new Rank("Grandmaster 4", overwatch2);
            Rank grandmaster3 = new Rank("Grandmaster 3", overwatch2);
            Rank grandmaster2 = new Rank("Grandmaster 2", overwatch2);
            Rank grandmaster1 = new Rank("Grandmaster 1", overwatch2);

            bronze5.setPrevRank(null);
            bronze5.setNextRank(bronze4);

            bronze4.setPrevRank(bronze5);
            bronze4.setNextRank(bronze3);

            bronze3.setPrevRank(bronze4);
            bronze3.setNextRank(bronze2);

            bronze2.setPrevRank(bronze3);
            bronze2.setNextRank(bronze1);

            bronze1.setPrevRank(bronze2);
            bronze1.setNextRank(silver5);

            silver5.setPrevRank(bronze1);
            silver5.setNextRank(silver4);

            silver4.setPrevRank(silver5);
            silver4.setNextRank(silver3);

            silver3.setPrevRank(silver4);
            silver3.setNextRank(silver2);

            silver2.setPrevRank(silver3);
            silver2.setNextRank(silver1);

            silver1.setPrevRank(silver2);
            silver1.setNextRank(gold5);

            gold5.setPrevRank(silver1);
            gold5.setNextRank(gold4);

            gold4.setPrevRank(gold5);
            gold4.setNextRank(gold3);

            gold3.setPrevRank(gold4);
            gold3.setNextRank(gold2);

            gold2.setPrevRank(gold3);
            gold2.setNextRank(gold1);

            gold1.setPrevRank(gold2);
            gold1.setNextRank(platinum5);

            platinum5.setPrevRank(gold1);
            platinum5.setNextRank(platinum4);

            platinum4.setPrevRank(platinum5);
            platinum4.setNextRank(platinum3);

            platinum3.setPrevRank(platinum4);
            platinum3.setNextRank(platinum2);

            platinum2.setPrevRank(platinum3);
            platinum2.setNextRank(platinum1);

            platinum1.setPrevRank(platinum2);
            platinum1.setNextRank(diamond5);

            diamond5.setPrevRank(platinum1);
            diamond5.setNextRank(diamond4);

            diamond4.setPrevRank(diamond5);
            diamond4.setNextRank(diamond3);

            diamond3.setPrevRank(diamond4);
            diamond3.setNextRank(diamond2);

            diamond2.setPrevRank(diamond3);
            diamond2.setNextRank(diamond1);

            diamond1.setPrevRank(diamond2);
            diamond1.setNextRank(master1);

            master5.setPrevRank(diamond1);
            master5.setNextRank(master4);

            master4.setPrevRank(master5);
            master4.setNextRank(master3);

            master3.setPrevRank(master4);
            master3.setNextRank(master2);

            master2.setPrevRank(master3);
            master2.setNextRank(master1);

            master1.setPrevRank(master2);
            master1.setNextRank(grandmaster5);

            grandmaster5.setPrevRank(master1);
            grandmaster5.setNextRank(grandmaster4);

            grandmaster4.setPrevRank(grandmaster5);
            grandmaster4.setNextRank(grandmaster3);

            grandmaster3.setPrevRank(grandmaster4);
            grandmaster3.setNextRank(grandmaster2);

            grandmaster2.setPrevRank(grandmaster3);
            grandmaster2.setNextRank(grandmaster1);

            grandmaster1.setPrevRank(grandmaster2);
            grandmaster1.setNextRank(null);
        }

        public override void OnGameInstalled(OnGameInstalledEventArgs args)
        {
            // Add code to be executed when game is finished installing.
        }

        public override void OnGameStarted(OnGameStartedEventArgs args)
        {
            // Add code to be executed when game is started running.
        }

        public override void OnGameStarting(OnGameStartingEventArgs args)
        {
            // Add code to be executed when game is preparing to be started.
        }

        public override void OnGameStopped(OnGameStoppedEventArgs args)
        {
            // Add code to be executed when game is preparing to be started.
        }

        public override void OnGameUninstalled(OnGameUninstalledEventArgs args)
        {
            // Add code to be executed when game is uninstalled.
        }

        public override void OnApplicationStarted(OnApplicationStartedEventArgs args)
        {
            // Add code to be executed when Playnite is initialized.

        }

        public override void OnApplicationStopped(OnApplicationStoppedEventArgs args)
        {
            // Add code to be executed when Playnite is shutting down.
        }

        public override void OnLibraryUpdated(OnLibraryUpdatedEventArgs args)
        {
            // Add code to be executed when library is updated.
        }

        public override ISettings GetSettings(bool firstRunSettings)
        {
            return settings;
        }

        public override UserControl GetSettingsView(bool firstRunSettings)
        {
            return new PlayniteRanksSettingsView();
        }
    }
}