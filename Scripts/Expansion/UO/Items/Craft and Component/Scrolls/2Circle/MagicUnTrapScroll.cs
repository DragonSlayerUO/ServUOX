namespace Server.Items
{
    public class MagicUnTrapScroll : SpellScroll
    {
        [Constructible]
        public MagicUnTrapScroll()
            : this(1)
        {
        }

        [Constructible]
        public MagicUnTrapScroll(int amount)
            : base(13, 0x1F3A, amount)
        {
        }

        public MagicUnTrapScroll(Serial serial)
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
