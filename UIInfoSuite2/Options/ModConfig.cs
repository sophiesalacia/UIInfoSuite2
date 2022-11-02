using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace UIInfoSuite2.Options
{
    internal class ModConfig
    {
        public bool ShowOptionsTabInMenu { get; set; } = true;
        public string ApplyDefaultSettingsFromThisSave { get; set; } = "JohnDoe_123456789";
        public KeybindList OpenCalendarKeybind { get; set; } = KeybindList.ForSingle(SButton.B);
        public KeybindList OpenQuestBoardKeybind { get; set; } = KeybindList.ForSingle(SButton.H);

        public Color FarmingColor { get; set; } = Color.ForestGreen;
        public Color FishingColor { get; set; } = Color.AliceBlue;
		public Color ForagingColor { get; set; } = Color.Yellow;
		public Color MiningColor { get; set; } = Color.DarkSlateGray;
		public Color CombatColor { get; set; } = Color.IndianRed;
    }
}
