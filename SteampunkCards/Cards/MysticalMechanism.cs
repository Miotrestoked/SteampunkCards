using System.Collections.Generic;
using ModdingUtils.Utils;
using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards
{
    class MysticalMechanism : CustomCard
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
            List<Player> opponents = PlayerStatus.GetEnemyPlayers(player);

            var cards = ModdingUtils.Utils.Cards.instance;

            opponents.ForEach(opp =>
            {
                int roll = new System.Random().Next(0, SteampunkCards.debuffCards.Count);
                cards.AddCardToPlayer(opp, SteampunkCards.debuffCards[roll], false, ":(", 0, 0);
            });
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Mystical Mechanism";
        }

        protected override string GetDescription()
        {
            return "Your enemies get a random curse";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.C_MysticalMechanism;
        }

        protected override CardInfo.Rarity GetRarity()
        {
            return CardInfo.Rarity.Rare;
        }

        protected override CardInfoStat[] GetStats()
        {
            return new CardInfoStat[]
            {
            };
        }

        protected override CardThemeColor.CardThemeColorType GetTheme()
        {
            return CardThemeColor.CardThemeColorType.EvilPurple;
        }

        public override string GetModName()
        {
            return SteampunkCards.ModInitials;
        }
    }
}