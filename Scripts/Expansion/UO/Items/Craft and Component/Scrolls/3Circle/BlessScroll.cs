namespace Server.Items
{
    public class BlessScroll : SpellScroll
    {
        [Constructible]
        public BlessScroll()
            : this(1)
        {
        }

        [Constructible]
        public BlessScroll(int amount)
            : base(16, 0x1F3D, amount)
        {
        }

        public BlessScroll(Serial serial)
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
