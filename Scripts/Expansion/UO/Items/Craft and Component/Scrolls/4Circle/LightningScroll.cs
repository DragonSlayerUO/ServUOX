namespace Server.Items
{
    public class LightningScroll : SpellScroll
    {
        [Constructible]
        public LightningScroll()
            : this(1)
        {
        }

        [Constructible]
        public LightningScroll(int amount)
            : base(29, 0x1F4A, amount)
        {
        }

        public LightningScroll(Serial serial)
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
