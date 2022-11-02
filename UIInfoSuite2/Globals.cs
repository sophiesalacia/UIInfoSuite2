using StardewModdingAPI;
using StardewModdingAPI.Events;
using UIInfoSuite2.Options;

namespace UIInfoSuite2
{

	internal class Globals
	{
		public static ModConfig Config { get; set; }
		public static IManifest Manifest { get; set; }
		public static IModHelper Helper { get; set; }
		public static ICommandHelper CCHelper => Helper.ConsoleCommands;
		public static IGameContentHelper GameContent => Helper.GameContent;
		public static IModContentHelper ModContent => Helper.ModContent;
		public static IContentPackHelper ContentPackHelper => Helper.ContentPacks;
		public static IDataHelper DataHelper => Helper.Data;
		public static IInputHelper InputHelper => Helper.Input;
		public static IModEvents EventHelper => Helper.Events;
		public static IMultiplayerHelper MultiplayerHelper => Helper.Multiplayer;
		public static IReflectionHelper ReflectionHelper => Helper.Reflection;
		public static ITranslationHelper TranslationHelper => Helper.Translation;
		public static string UUID => Manifest.UniqueID;
	}
}