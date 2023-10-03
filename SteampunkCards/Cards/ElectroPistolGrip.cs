using System.Linq;
using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards
{
    class ElectroPistolGrip : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
            var objectToSpawn = new ObjectsToSpawn();
            var item = new GameObject();
            var rhb = item.AddComponent<RayHitBash>();
            rhb.baseStunTime = 0.25f;
            objectToSpawn.AddToProjectile = item;

            var list = gun.objectsToSpawn.ToList();
            list.Add(objectToSpawn);
            gun.objectsToSpawn = list.ToArray();
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Electro pistol grip";
        }

        protected override string GetDescription()
        {
            return
                "The embedded electric generator in this pistol grip generates a charge that will stun an opponent upon impact.";
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Common;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.ColdBlue;
        }

        public override string GetModName()
        {
            return SteampunkCards.ModInitials;
        }
    }
}