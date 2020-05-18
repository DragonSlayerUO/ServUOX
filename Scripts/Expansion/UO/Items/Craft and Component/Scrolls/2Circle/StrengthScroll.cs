namespace Server.Items
{
    public class StrengthScroll : SpellScroll
    {
        [Constructible]
        public StrengthScroll()
            : this(1)
        {
        }

        [Constructible]
        public StrengthScroll(int amount)
            : base(15, 0x1F3C, amount)
        {
        }

        public StrengthScroll(Serial serial)
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
