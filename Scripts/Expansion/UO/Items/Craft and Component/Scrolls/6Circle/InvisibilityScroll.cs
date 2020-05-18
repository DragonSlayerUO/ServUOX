namespace Server.Items
{
    public class InvisibilityScroll : SpellScroll
    {
        [Constructible]
        public InvisibilityScroll()
            : this(1)
        {
        }

        [Constructible]
        public InvisibilityScroll(int amount)
            : base(43, 0x1F58, amount)
        {
        }

        public InvisibilityScroll(Serial serial)
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
