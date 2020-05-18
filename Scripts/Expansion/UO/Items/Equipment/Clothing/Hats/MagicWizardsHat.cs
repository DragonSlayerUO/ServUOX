namespace Server.Items
{
    public class MagicWizardsHat : BaseHat
    {
        public override int BasePhysicalResistance => 0;
        public override int BaseFireResistance => 5;
        public override int BaseColdResistance => 9;
        public override int BasePoisonResistance => 5;
        public override int BaseEnergyResistance => 5;

        public override int InitMinHits => 20;
        public override int InitMaxHits => 30;

        public override int LabelNumber => 1041072;// a magical wizard's hat

        public override int BaseStrBonus => -5;
        public override int BaseDexBonus => -5;
        public override int BaseIntBonus => +5;

        [Constructible]
        public MagicWizardsHat()
            : this(0)
        {
        }

        [Constructible]
        public MagicWizardsHat(int hue)
            : base(0x1718, hue)
        {
            Weight = 1.0;
        }

        public MagicWizardsHat(Serial serial)
            : base(serial)
        {
        }

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
