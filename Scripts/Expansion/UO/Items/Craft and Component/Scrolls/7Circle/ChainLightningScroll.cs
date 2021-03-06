namespace Server.Items
{
    public class ChainLightningScroll : SpellScroll
    {
        [Constructible]
        public ChainLightningScroll()
            : this(1)
        {
        }

        [Constructible]
        public ChainLightningScroll(int amount)
            : base(48, 0x1F5D, amount)
        {
        }

        public ChainLightningScroll(Serial serial)
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
