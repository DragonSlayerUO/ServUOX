using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefBlacksmithy), typeof(DualPointedSpear))]
    [Flipable(0xF62, 0xF63)]
    public class Spear : BaseSpear
    {
        [Constructible]
        public Spear()
            : base(0xF62)
        {
            Weight = 7.0;
        }

        public Spear(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.ArmorIgnore;
        public override WeaponAbility SecondaryAbility => WeaponAbility.ParalyzingBlow;
        public override int AosStrengthReq => 50;
        public override int AosMinDamage => 13;
        public override int AosMaxDamage => 16;
        public override int AosSpeed => 42;
        public override float MlSpeed => 2.75f;
        public override int OldStrengthReq => 30;
        public override int OldMinDamage => 2;
        public override int OldMaxDamage => 36;
        public override int OldSpeed => 46;
        public override int InitMinHits => 31;
        public override int InitMaxHits => 80;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }
}
