using UnityEngine;

namespace SteampunkCards
{
    internal class Assets
    {
        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("assets", typeof(SteampunkCards).Assembly);

        public static GameObject C_AegisRejuvenatorUnit = Bundle.LoadAsset<GameObject>("C_AegisRejuvenatorUnit");
        public static GameObject C_BarrierRegenerator = Bundle.LoadAsset<GameObject>("C_BarrierRegenerator");
        public static GameObject C_CacheAugmentator = Bundle.LoadAsset<GameObject>("C_CacheAugmentator");
        public static GameObject C_ChamberExtension = Bundle.LoadAsset<GameObject>("C_ChamberExtension");
        public static GameObject C_ClockworkTriggerMechanism = Bundle.LoadAsset<GameObject>("C_ClockworkTriggerMechanism");
        public static GameObject C_ClockworkWingsuit = Bundle.LoadAsset<GameObject>("C_ClockworkWingsuit");
        public static GameObject C_DeflectorArray = Bundle.LoadAsset<GameObject>("C_DeflectorArray");
        public static GameObject C_ElectroPistolGrip = Bundle.LoadAsset<GameObject>("C_ElectroPistolGrip");
        public static GameObject C_ExpandedReservoir = Bundle.LoadAsset<GameObject>("C_ExpandedReservoir");
        public static GameObject C_GatlingSteamGun = Bundle.LoadAsset<GameObject>("C_GatlingSteamGun");
        public static GameObject C_GearDrivenSniperScope = Bundle.LoadAsset<GameObject>("C_GearDrivenSniperScope");
        public static GameObject C_JumpEnhancer = Bundle.LoadAsset<GameObject>("C_JumpEnhancer");
        public static GameObject C_LeapAmplifier = Bundle.LoadAsset<GameObject>("C_LeapAmplifier");
        public static GameObject C_MultiBarrelSteamShotgun = Bundle.LoadAsset<GameObject>("C_MultiBarrelSteamShotgun");
        public static GameObject C_SteamEnhancedAmmoLoader = Bundle.LoadAsset<GameObject>("C_SteamEnhancedAmmoLoader");
        public static GameObject C_SteamPoweredBoots = Bundle.LoadAsset<GameObject>("C_SteamPoweredBoots");
        public static GameObject C_SteamPoweredRevolver = Bundle.LoadAsset<GameObject>("C_SteamPoweredRevolver");
    }
}