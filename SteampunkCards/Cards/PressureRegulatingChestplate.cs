using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards
{
    class PressureRegulatingChestplate : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
            statModifiers.health = 1.2f;
            statModifiers.movementSpeed = 0.95f;
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Edits values on player when card is selected
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Pressure-Regulating Chestplate";
        }

        protected override string GetDescription()
        {
            return "A chestplate equipped with a steam-powered pressure-regulating system.";
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
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Health",
                    amount = "+20%",
                    simepleAmount = CardInfoStat.SimpleAmount.Some
                },
                new CardInfoStat()
                {
                    positive = false,
                    stat = "Movement speed",
                    amount = "-5%",
                    simepleAmount = CardInfoStat.SimpleAmount.Some
                }
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