using System;

namespace Server.Items
{
    [Flipable(0x26C3, 0x26CD)]
    public class RepeatingCrossbow : BaseRanged
    {
        [Constructible]
        public RepeatingCrossbow()
            : base(0x26C3)
        {
            Weight = 6.0;
        }

        public RepeatingCrossbow(Serial serial)
            : base(serial)
        {
        }

        public override int EffectID => 0x1BFE;
        public override Type AmmoType => typeof(Bolt);
        public override Item Ammo => new Bolt();
        public override WeaponAbility PrimaryAbility => WeaponAbility.DoubleStrike;
        public override WeaponAbility SecondaryAbility => WeaponAbility.MovingShot;
        public override int AosStrengthReq => 30;
        public override int AosMinDamage => Core.ML ? 11 : 10;
        public override int AosMaxDamage => 15;
        public override int AosSpeed => 41;
        public override float MlSpeed => 2.75f;
        public override int OldStrengthReq => 30;
        public override int OldMinDamage => 10;
        public override int OldMaxDamage => 12;
        public override int OldSpeed => 41;
        public override int DefMaxRange => 7;
        public override int InitMinHits => 31;
        public override int InitMaxHits => 80;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}