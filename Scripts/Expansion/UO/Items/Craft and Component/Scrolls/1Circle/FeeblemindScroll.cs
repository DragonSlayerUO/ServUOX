namespace Server.Items
{
    public class FeeblemindScroll : SpellScroll
    {
        [Constructible]
        public FeeblemindScroll()
            : this(1)
        {
        }

        [Constructible]
        public FeeblemindScroll(int amount)
            : base(2, 0x1F30, amount)
        {
        }

        public FeeblemindScroll(Serial serial)
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
