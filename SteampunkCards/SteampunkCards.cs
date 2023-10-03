using System.Collections.Generic;
using BepInEx;
using HarmonyLib;

namespace SteampunkCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInDependency("pykess.rounds.plugins.moddingutils")]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch")]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class SteampunkCards : BaseUnityPlugin
    {
        private const string ModId = "spam.mods.steampunkcards";
        private const string ModName = "Steampunk Cards";
        public const string Version = "1.0.0"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "SPC";

        internal static List<CardInfo> debuffCards = new List<CardInfo>();
        internal static List<CardInfo> buffCards = new List<CardInfo>();

        public static SteampunkCards instance { get; private set; }

        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        void Start()
        {
            instance = this;
            loadCards();
        }

        void loadCards()
        {
        }

        public static CardInfo FindCard(string cardName)
        {
            var cards = ModdingUtils.Utils.Cards.instance;

            return cards.GetCardWithObjectName($"__{ModInitials}__{cardName}");
        }
    }
}