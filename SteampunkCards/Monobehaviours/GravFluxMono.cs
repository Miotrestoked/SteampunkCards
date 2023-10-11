using System;
using ModdingUtils.MonoBehaviours;
using UnboundLib;
using UnityEngine;

namespace SteampunkCards.MonoBehaviours
{
    public class GravFluxMono : MonoBehaviour
    {
        private Player player;
        private Block block;
        private Action<BlockTrigger.BlockTriggerType> gravReverse;
        private Action<BlockTrigger.BlockTriggerType> previous;

        private void Awake()
        {
            player = GetComponent<Player>();
            block = GetComponent<Block>();

            previous = block.BlockAction;

            gravReverse = new Action<BlockTrigger.BlockTriggerType>(OnBlock(player, block).Invoke);
            block.BlockAction = (Action<BlockTrigger.BlockTriggerType>)Delegate.Combine(block.BlockAction, gravReverse);
        }

        private void Start()
        {
        }

        private void Update()
        {
        }

        public void OnDestroy()
        {
            block.BlockAction = previous;
        }

        public Action<BlockTrigger.BlockTriggerType> OnBlock(Player player, Block block)
        {
            return delegate (BlockTrigger.BlockTriggerType trigger)
            {
                player.gameObject.GetOrAddComponent<GravityReverseEffect>();
            };
        }
    }

    public class GravityReverseEffect : ReversibleEffect
    {
        private readonly float duration = 2f;
        private float startTime;

        public override void OnAwake()
        {
            player = GetComponent<Player>();

            player.data.stats.gravity *= -1;
        }

        public override void OnStart()
        {
            startTime = Time.time;
        }

        public override void OnOnDestroy()
        {
            player.data.stats.gravity *= -1;
        }

        public override void OnUpdate()
        {
            if (Time.time > startTime + duration)
            {
                Destroy(this);
            }
        }
    }
}