namespace Server.Items
{
    public class EnergyBoltScroll : SpellScroll
    {
        [Constructible]
        public EnergyBoltScroll()
            : this(1)
        {
        }

        [Constructible]
        public EnergyBoltScroll(int amount)
            : base(41, 0x1F56, amount)
        {
        }

        public EnergyBoltScroll(Serial serial)
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
