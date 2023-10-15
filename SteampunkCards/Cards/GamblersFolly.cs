using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards.Curses
{
    class GamblersFolly : CustomCard
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
            var cards = ModdingUtils.Utils.Cards.instance;

            var random = new System.Random();
            int luck = random.Next(0, 100);
            if (luck < 95) //blessing
            {
                int buff = random.Next(0, SteampunkCards.buffCards.Count);
                cards.AddCardToPlayer(player, SteampunkCards.buffCards[buff], false, ":)", 0, 0);
                return;
            }
            //curse
            int curse = random.Next(0, SteampunkCards.debuffCards.Count);
            cards.AddCardToPlayer(player, SteampunkCards.debuffCards[curse], false, ":(", 0, 0);
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Gamblers Folly";
        }

        protected override string GetDescription()
        {
            return "95% chance to get a Blessing, but if you're unlucky you get a curse...";
        }

        protected override GameObject GetCardArt()
        {
            return null;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Uncommon;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
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