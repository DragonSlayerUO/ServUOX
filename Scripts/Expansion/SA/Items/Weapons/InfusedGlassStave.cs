using System;

namespace Server.Items
{
    // Based off a BlackStaff
    [Flipable(0x905, 0x4070)]
    public class InfusedGlassStave : BaseStaff
    {
        public override int LabelNumber => 1112909;  // infused glass stave

        [Constructable]
        public InfusedGlassStave()
            : base(0x905)
        {
            Weight = 4.0;
            Hue = 23;
        }

        public InfusedGlassStave(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.DoubleStrike;
        public override WeaponAbility SecondaryAbility => WeaponAbility.MortalStrike;
        public override int AosStrengthReq => 20;
        public override int AosMinDamage => 11;
        public override int AosMaxDamage => 14;
        public override int AosSpeed => 39;
        public override float MlSpeed => 2.25f;
        public override int OldStrengthReq => 35;
        public override int OldMinDamage => 8;
        public override int OldMaxDamage => 33;
        public override int OldSpeed => 35;
        public override int InitMinHits => 31;
        public override int InitMaxHits => 70;
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}