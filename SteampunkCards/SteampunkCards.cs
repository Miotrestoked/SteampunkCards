using System.Collections.Generic;
using BepInEx;
using HarmonyLib;
using SteampunkCards.Cards;
using UnboundLib.Cards;

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
            --CustomCard.BuildCard<AegisRejuvenatorUnit>();
            --CustomCard.BuildCard<BarrierGenerator>();
            --CustomCard.BuildCard<CacheAugmentator>();
            --CustomCard.BuildCard<ChamberExtension>();
            --CustomCard.BuildCard<ClockworkTriggerMechanism>(); add delay between bullets
            //CustomCard.BuildCard<ClockworkWingsuit>();
            -- CustomCard.BuildCard<DeflectorArray>(); naar 2
            -- CustomCard.BuildCard<ElectroPistolGrip>(); naar 0.25s
            -- CustomCard.BuildCard<ExpandedReservoir>(); naar 5
            --CustomCard.BuildCard<GatlingSteamGun>(); attack speed verkeerdom
            --CustomCard.BuildCard<GearDrivenSniperScope>();
            CustomCard.BuildCard<JumpEnhancer>();
            --CustomCard.BuildCard<LeapAmplifier>();
            -- CustomCard.BuildCard<PneumaticRifleStock>();
            --CustomCard.BuildCard<SteamEnhancedAmmoLoader>();
            --CustomCard.BuildCard<SteamPoweredBoots>();
            --CustomCard.BuildCard<SteamPoweredRevolver>();
            //CustomCard.BuildCard<TemporalModulator>();
            --CustomCard.BuildCard<VaultAugmentator>();
            --CustomCard.BuildCard<BoilerplateArmorPiercingRounds>();
            --CustomCard.BuildCard<BoilerplateShoulderStock>(); add delay between bullets
            --CustomCard.BuildCard<BrassEjectorMechanism>();
            --CustomCard.BuildCard<CogwheelEnhancedBullets>();
            --CustomCard.BuildCard<CogwheelMedpack>();
            --CustomCard.BuildCard<MechanicalHeartImplant>();
            --CustomCard.BuildCard<MultiBarrelSteamShotgun>(); meer spread
            --CustomCard.BuildCard<PressureBoostedBullets>(); damagea
            --CustomCard.BuildCard<PressureRegulatingChestplate>();
            //CustomCard.BuildCard<RapidReloadBandolier>();
            //CustomCard.BuildCard<SteamInfusedAmmunition>();
            --CustomCard.BuildCard<SteamPoweredRailgun>(); attack speed verkeerdom
            --CustomCard.BuildCard<SynchronizedShotTimer>();
        }

        public static CardInfo FindCard(string cardName)
        {
            var cards = ModdingUtils.Utils.Cards.instance;

            return cards.GetCardWithObjectName($"__{ModInitials}__{cardName}");
        }
    }
}