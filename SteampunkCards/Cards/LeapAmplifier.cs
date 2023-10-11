using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards
{
    class LeapAmplifier : CustomCard
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
            data.jumps += 2;
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Leap amplifier";
        }

        protected override string GetDescription()
        {
            return "";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.C_LeapAmplifier;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
                new CardInfoStat()
                {
                    positive = true,
                    stat = "Jumps",
                    amount = "+2",
                    simepleAmount = CardInfoStat.SimpleAmount.aLittleBitOf
                }
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.PoisonGreen;
        }

        public override string GetModName()
        {
            return SteampunkCards.ModInitials;
        }
    }
}