using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefBlacksmithy), typeof(GargishTessen))]
    [Flipable(0x27A3, 0x27EE)]
    public class Tessen : BaseBashing
    {
        [Constructable]
        public Tessen()
            : base(0x27A3)
        {
            this.Weight = 6.0;
            this.Layer = Layer.TwoHanded;
        }

        public Tessen(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.Feint;
        public override WeaponAbility SecondaryAbility => WeaponAbility.DualWield;
        public override int AosStrengthReq => 10;
        public override int AosMinDamage => 10;
        public override int AosMaxDamage => 13;
        public override int AosSpeed => 50;
        public override float MlSpeed => 2.00f;
        public override int OldStrengthReq => 10;
        public override int OldMinDamage => 10;
        public override int OldMaxDamage => 12;
        public override int OldSpeed => 50;
        public override int DefHitSound => 0x232;
        public override int DefMissSound => 0x238;
        public override int InitMinHits => 55;
        public override int InitMaxHits => 60;
        public override WeaponAnimation DefAnimation => WeaponAnimation.Bash2H;
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