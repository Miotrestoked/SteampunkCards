using System.Collections.Generic;
using ModdingUtils.Utils;
using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards
{
    class CogsOfConstraint : CustomCard
    {
        public override void SetupCard(CardInfo cardInfo, Gun gun, ApplyCardStats cardStats,
            CharacterStatModifiers statModifiers, Block block)
        {
            //Edits values on card itself, which are then applied to the player in `ApplyCardStats`
        }

        public override void OnAddCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            List<Player> opponents = PlayerStatus.GetEnemyPlayers(player);
            
            var cards = ModdingUtils.Utils.Cards.instance;
            
            opponents.ForEach(opp => cards.AddCardToPlayer(opp, SteampunkCards.FindCard("Gyroscopic Anchor"), false, "ZI", 0, 0));
            //Edits values on player when card is selected
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Cogs of Constraint";
        }

        protected override string GetDescription()
        {
            return "The movement speed of all enemies is reduced by 30%";
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