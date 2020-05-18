namespace Server.Items
{
    public class MagicTrapScroll : SpellScroll
    {
        [Constructible]
        public MagicTrapScroll()
            : this(1)
        {
        }

        [Constructible]
        public MagicTrapScroll(int amount)
            : base(12, 0x1F39, amount)
        {
        }

        public MagicTrapScroll(Serial serial)
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
