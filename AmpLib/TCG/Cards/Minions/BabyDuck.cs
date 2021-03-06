﻿namespace AmpLib.TCG.Cards.Minions
{
    public sealed class BabyDuck : MinionCard
    {
        public const int Id = 1;

        public override int Attack { get; set; }
        public override int MaxAttack { get; set; }

        public override int Health { get; set; }
        public override int MaxHealth { get; set; }

        public BabyDuck()
        {
            Name = "Baby Duck";
            Cost = 1;
            Attack = MaxAttack = 1;
            Health = MaxHealth = 2;
            Rarity = RarityEnum.White;
            IsAlive = true;
        }
    }
}   