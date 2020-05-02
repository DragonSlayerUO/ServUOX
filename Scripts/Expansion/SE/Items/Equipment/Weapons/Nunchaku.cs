using System;

namespace Server.Items
{
    [Flipable(0x27AE, 0x27F9)]
    public class Nunchaku : BaseBashing
    {
        [Constructable]
        public Nunchaku()
            : base(0x27AE)
        {
            this.Weight = 5.0;
        }

        public Nunchaku(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.Block;
        public override WeaponAbility SecondaryAbility => WeaponAbility.DoubleStrike;
        public override int AosStrengthReq => 15;
        public override int AosMinDamage => 12;
        public override int AosMaxDamage => 15;
        public override int AosSpeed => 47;
        public override float MlSpeed => 2.50f;
        public override int OldStrengthReq => 15;
        public override int OldMinDamage => 11;
        public override int OldMaxDamage => 13;
        public override int OldSpeed => 47;
        public override int DefHitSound => 0x535;
        public override int DefMissSound => 0x239;
        public override int InitMinHits => 40;
        public override int InitMaxHits => 55;
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