using Playnite.SDK;
using Playnite.SDK.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayniteRanks
{
    public class PlayniteRanksSettings : ObservableObject
    {


        // Playnite serializes settings object to a JSON object and saves it as text file.
        // If you want to exclude some property from being saved then use `JsonDontSerialize` ignore attribute.

        private bool optionThatWontBeSaved = false;
        [DontSerialize]
        public bool OptionThatWontBeSaved { get => optionThatWontBeSaved; set => SetValue(ref optionThatWontBeSaved, value); }
    }

    public class PlayniteRanksSettingsViewModel : ObservableObject, ISettings
    {
        private readonly PlayniteRanks plugin;
        private PlayniteRanksSettings editingClone { get; set; }

        private PlayniteRanksSettings settings;

        public Game overwatch2 = new Game("Overwatch 2");


        public PlayniteRanksSettings Settings
        {

            get => settings;
            set
            {
                settings = value;
                OnPropertyChanged();
            }


        }

        public PlayniteRanksSettingsViewModel(PlayniteRanks plugin)
        {
            // Injecting your plugin instance is required for Save/Load method because Playnite saves data to a location based on what plugin requested the operation.
            this.plugin = plugin;

            // Load saved settings.
            var savedSettings = plugin.LoadPluginSettings<PlayniteRanksSettings>();

            // LoadPluginSettings returns null if no saved data is available.
            if (savedSettings != null)
            {
                Settings = savedSettings;
            }
            else
            {
                Settings = new PlayniteRanksSettings();
            }

            

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

            // Set previous and next ranks for bronze ranks
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

            // Set previous and next ranks for silver ranks
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

            // Set previous and next ranks for gold ranks
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

            // Set previous and next ranks for platinum ranks
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

            // Set previous and next ranks for diamond ranks
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

            // Set previous and next ranks for master ranks
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

            // Set previous and next ranks for grandmaster ranks
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

            // Add the existing Rank objects to the Overwatch 2 Object Ranks list
            overwatch2.addRank(bronze5);
            overwatch2.addRank(bronze4);
            overwatch2.addRank(bronze3);
            overwatch2.addRank(bronze2);
            overwatch2.addRank(bronze1);

            overwatch2.addRank(silver5);
            overwatch2.addRank(silver4);
            overwatch2.addRank(silver3);
            overwatch2.addRank(silver2);
            overwatch2.addRank(silver1);

            overwatch2.addRank(gold5);
            overwatch2.addRank(gold4);
            overwatch2.addRank(gold3);
            overwatch2.addRank(gold2);
            overwatch2.addRank(gold1);

            overwatch2.addRank(platinum5);
            overwatch2.addRank(platinum4);
            overwatch2.addRank(platinum3);
            overwatch2.addRank(platinum2);
            overwatch2.addRank(platinum1);

            overwatch2.addRank(diamond5);
            overwatch2.addRank(diamond4);
            overwatch2.addRank(diamond3);
            overwatch2.addRank(diamond2);
            overwatch2.addRank(diamond1);

            overwatch2.addRank(master5);
            overwatch2.addRank(master4);
            overwatch2.addRank(master3);
            overwatch2.addRank(master2);
            overwatch2.addRank(master1);

            overwatch2.addRank(grandmaster5);
            overwatch2.addRank(grandmaster4);
            overwatch2.addRank(grandmaster3);
            overwatch2.addRank(grandmaster2);
            overwatch2.addRank(grandmaster1);
        }

        public void BeginEdit()
        {
            // Code executed when settings view is opened and user starts editing values.
            editingClone = Serialization.GetClone(Settings);
        }

        public void CancelEdit()
        {
            // Code executed when user decides to cancel any changes made since BeginEdit was called.
            // This method should revert any changes made to Option1 and Option2.
            Settings = editingClone;
        }

        public void EndEdit()
        {
            // Code executed when user decides to confirm changes made since BeginEdit was called.
            // This method should save settings made to Option1 and Option2.
            plugin.SavePluginSettings(Settings);
        }

        public bool VerifySettings(out List<string> errors)
        {
            // Code execute when user decides to confirm changes made since BeginEdit was called.
            // Executed before EndEdit is called and EndEdit is not called if false is returned.
            // List of errors is presented to user if verification fails.
            errors = new List<string>();
            return true;
        }
    }
}