using UnityEngine;

namespace SteampunkCards
{
    internal class Assets
    {
        private static readonly AssetBundle Bundle = Jotunn.Utils.AssetUtils.LoadAssetBundleFromResources("assets", typeof(SteampunkCards).Assembly);

        public static GameObject C_AegisRejuvenatorUnit = Bundle.LoadAsset<GameObject>("C_AegisRejuvenatorUnit");
        public static GameObject C_BarrierRegenerator = Bundle.LoadAsset<GameObject>("C_BarrierRegenerator");
        public static GameObject C_BoilerplateArmorPiercingRounds = Bundle.LoadAsset<GameObject>("C_BoilerplateArmorPiercingRounds");
        public static GameObject C_BoilerplateShoulderStock = Bundle.LoadAsset<GameObject>("C_BoilerplateShoulderStock");
        public static GameObject C_BrassBulwark = Bundle.LoadAsset<GameObject>("C_BrassBulwark");
        public static GameObject C_BrassEjectorMechanism = Bundle.LoadAsset<GameObject>("C_BrassEjectorMechanism");
        public static GameObject C_CacheAugmentator = Bundle.LoadAsset<GameObject>("C_CacheAugmentator");
        public static GameObject C_ChamberExtension = Bundle.LoadAsset<GameObject>("C_ChamberExtension");
        public static GameObject C_ClockworkTriggerMechanism = Bundle.LoadAsset<GameObject>("C_ClockworkTriggerMechanism");
        public static GameObject C_ClockworkWingsuit = Bundle.LoadAsset<GameObject>("C_ClockworkWingsuit");
        public static GameObject C_CogsOfConstraint = Bundle.LoadAsset<GameObject>("C_CogsOfConstraint");
        public static GameObject C_CogwheelEnhancedBullets = Bundle.LoadAsset<GameObject>("C_CogwheelEnhancedBullets");
        public static GameObject C_CogwheelMedpack = Bundle.LoadAsset<GameObject>("C_CogwheelMedpack");
        public static GameObject C_DeflectorArray = Bundle.LoadAsset<GameObject>("C_DeflectorArray");
        public static GameObject C_ElectroPistolGrip = Bundle.LoadAsset<GameObject>("C_ElectroPistolGrip");
        public static GameObject C_ExoSuit = Bundle.LoadAsset<GameObject>("C_ExoSuit");
        public static GameObject C_ExpandedReservoir = Bundle.LoadAsset<GameObject>("C_ExpandedReservoir");
        public static GameObject C_GamblersFolly = Bundle.LoadAsset<GameObject>("C_GamblersFolly");
        public static GameObject C_GatlingSteamGun = Bundle.LoadAsset<GameObject>("C_GatlingSteamGun");
        public static GameObject C_GearDrivenSniperScope = Bundle.LoadAsset<GameObject>("C_GearDrivenSniperScope");
        public static GameObject C_GearsOfFortune = Bundle.LoadAsset<GameObject>("C_GearsOfFortune");
        public static GameObject C_Goggles = Bundle.LoadAsset<GameObject>("C_Goggles");
        public static GameObject C_GyroscopicGlide = Bundle.LoadAsset<GameObject>("C_GyroscopicGlide");
        public static GameObject C_JumpEnhancer = Bundle.LoadAsset<GameObject>("C_JumpEnhancer");
        public static GameObject C_LeapAmplifier = Bundle.LoadAsset<GameObject>("C_LeapAmplifier");
        public static GameObject C_MechanicalHeartImplant = Bundle.LoadAsset<GameObject>("C_MechanicalHeartImplant");
        public static GameObject C_MechanicalMomentum = Bundle.LoadAsset<GameObject>("C_MechanicalMomentum");
        public static GameObject C_MultiBarrelSteamShotgun = Bundle.LoadAsset<GameObject>("C_MultiBarrelSteamShotgun");
        public static GameObject C_MysticalMechanism = Bundle.LoadAsset<GameObject>("C_MysticalMechanism");
        public static GameObject C_PneumaticArmor = Bundle.LoadAsset<GameObject>("C_PneumaticArmor");
        public static GameObject C_PneumaticRifleStock = Bundle.LoadAsset<GameObject>("C_PneumaticRifleStock");
        public static GameObject C_PressureBoostedBullets = Bundle.LoadAsset<GameObject>("C_PressureBoostedBullets");
        public static GameObject C_PressureRegulatingChestplate = Bundle.LoadAsset<GameObject>("C_PressureRegulatingChestplate");
        public static GameObject C_RapidReloadBandolier = Bundle.LoadAsset<GameObject>("C_RapidReloadBandolier");
        public static GameObject C_SquishPiston = Bundle.LoadAsset<GameObject>("C_SquishPiston");
        public static GameObject C_SteamEnhancedAmmoLoader = Bundle.LoadAsset<GameObject>("C_SteamEnhancedAmmoLoader");
        public static GameObject C_SteamFortress = Bundle.LoadAsset<GameObject>("C_SteamFortress");
        public static GameObject C_SteamPoweredBoots = Bundle.LoadAsset<GameObject>("C_SteamPoweredBoots");
        public static GameObject C_SteamPoweredRailgun = Bundle.LoadAsset<GameObject>("C_SteamPoweredRailgun");
        public static GameObject C_SteamPoweredRevolver = Bundle.LoadAsset<GameObject>("C_SteamPoweredRevolver");
        public static GameObject C_TemporalModulator = Bundle.LoadAsset<GameObject>("C_TemporalModulator");
        public static GameObject C_VaultAugmentator = Bundle.LoadAsset<GameObject>("C_VaultAugmentator");
    }
}