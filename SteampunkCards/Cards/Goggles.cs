using System.Collections.Generic;
using ModdingUtils.Utils;
using UnboundLib.Cards;
using UnityEngine;

namespace SteampunkCards.Cards
{
    class Goggles : CustomCard
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
            
            opponents.ForEach(opp => cards.AddCardToPlayer(opp, SteampunkCards.FindCard("Zoomed In"), false, "ZI", 0, 0));
            //Edits values on player when card is selected
        }

        public override void OnRemoveCard(Player player, Gun gun, GunAmmo gunAmmo, CharacterData data,
            HealthHandler health, Gravity gravity, Block block, CharacterStatModifiers characterStats)
        {
            //Run when the card is removed from the player
        }

        protected override string GetTitle()
        {
            return "Goggles";
        }

        protected override string GetDescription()
        {
            return "All enemies gain 15% size";
        }

        protected override GameObject GetCardArt()
        {
            return Assets.C_Goggles;
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
                    stat = "To each enemy",
                    amount = "+15% size",
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