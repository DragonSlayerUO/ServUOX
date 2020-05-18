namespace Server.Items
{
    public class ManaDrainScroll : SpellScroll
    {
        [Constructible]
        public ManaDrainScroll()
            : this(1)
        {
        }

        [Constructible]
        public ManaDrainScroll(int amount)
            : base(30, 0x1F4B, amount)
        {
        }

        public ManaDrainScroll(Serial serial)
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
