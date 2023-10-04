using System.Collections.Generic;
using BepInEx;
using HarmonyLib;
using SteampunkCards.Cards;
using SteampunkCards.Cards.Curses;
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
            var cards = ModdingUtils.Utils.Cards.instance;
            
            CustomCard.BuildCard<AegisRejuvenatorUnit>();
            CustomCard.BuildCard<BarrierGenerator>();
            CustomCard.BuildCard<CacheAugmentator>();
            CustomCard.BuildCard<ChamberExtension>();
            CustomCard.BuildCard<ClockworkTriggerMechanism>();
            CustomCard.BuildCard<ClockworkWingsuit>();
            CustomCard.BuildCard<DeflectorArray>();
            CustomCard.BuildCard<ElectroPistolGrip>();
            CustomCard.BuildCard<ExpandedReservoir>();
            CustomCard.BuildCard<GatlingSteamGun>();
            CustomCard.BuildCard<GearDrivenSniperScope>();
            CustomCard.BuildCard<JumpEnhancer>();
            CustomCard.BuildCard<LeapAmplifier>();
            CustomCard.BuildCard<PneumaticRifleStock>();
            CustomCard.BuildCard<SteamEnhancedAmmoLoader>();
            CustomCard.BuildCard<SteamPoweredBoots>();
            CustomCard.BuildCard<SteamPoweredRevolver>();
            CustomCard.BuildCard<TemporalModulator>();
            CustomCard.BuildCard<VaultAugmentator>();
            CustomCard.BuildCard<BoilerplateArmorPiercingRounds>();
            CustomCard.BuildCard<BoilerplateShoulderStock>();
            CustomCard.BuildCard<BrassEjectorMechanism>();
            CustomCard.BuildCard<CogwheelEnhancedBullets>();
            CustomCard.BuildCard<CogwheelMedpack>();
            CustomCard.BuildCard<MechanicalHeartImplant>();
            CustomCard.BuildCard<MultiBarrelSteamShotgun>();
            CustomCard.BuildCard<PressureBoostedBullets>();
            CustomCard.BuildCard<PressureRegulatingChestplate>();
            CustomCard.BuildCard<RapidReloadBandolier>();
            //CustomCard.BuildCard<SteamInfusedAmmunition>();
            CustomCard.BuildCard<SteamPoweredRailgun>();
            CustomCard.BuildCard<SynchronizedShotTimer>();
            CustomCard.BuildCard<Goggles>();
            CustomCard.BuildCard<ZoomedIn>(DebuffCardInit);
            
            void BuffCardInit(CardInfo c)
            {
                cards.AddHiddenCard(c);
                buffCards.Add(c);
            }

            void DebuffCardInit(CardInfo c)
            {
                cards.AddHiddenCard(c);
                debuffCards.Add(c);
            }
        }

        public static CardInfo FindCard(string cardName)
        {
            var cards = ModdingUtils.Utils.Cards.instance;

            return cards.GetCardWithObjectName($"__{ModInitials}__{cardName}");
        }
        
        
    }
}