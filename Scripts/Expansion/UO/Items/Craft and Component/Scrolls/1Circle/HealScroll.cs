namespace Server.Items
{
    public class HealScroll : SpellScroll
    {
        [Constructible]
        public HealScroll()
            : this(1)
        {
        }

        [Constructible]
        public HealScroll(int amount)
            : base(3, 0x1F31, amount)
        {
        }

        public HealScroll(Serial serial)
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
