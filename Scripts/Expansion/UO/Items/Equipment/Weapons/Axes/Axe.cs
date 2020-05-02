using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefBlacksmithy), typeof(GargishAxe))]
    [Flipable(0xF49, 0xF4a)]
    public class Axe : BaseAxe
    {
        [Constructable]
        public Axe()
            : base(0xF49)
        {
            Weight = 4.0;
        }

        public Axe(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.CrushingBlow;
        public override WeaponAbility SecondaryAbility => WeaponAbility.Dismount;
        public override int AosStrengthReq => 35;
        public override int AosMinDamage => 14;
        public override int AosMaxDamage => 17;
        public override int AosSpeed => 37;
        public override float MlSpeed => 3.00f;
        public override int OldStrengthReq => 35;
        public override int OldMinDamage => 6;
        public override int OldMaxDamage => 33;
        public override int OldSpeed => 37;
        public override int InitMinHits => 31;
        public override int InitMaxHits => 110;
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
