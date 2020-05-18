namespace Server.Items
{
    public class EnergyFieldScroll : SpellScroll
    {
        [Constructible]
        public EnergyFieldScroll()
            : this(1)
        {
        }

        [Constructible]
        public EnergyFieldScroll(int amount)
            : base(49, 0x1F5E, amount)
        {
        }

        public EnergyFieldScroll(Serial serial)
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
