namespace Server.Items
{
    public class MagicLockScroll : SpellScroll
    {
        [Constructible]
        public MagicLockScroll()
            : this(1)
        {
        }

        [Constructible]
        public MagicLockScroll(int amount)
            : base(18, 0x1F3F, amount)
        {
        }

        public MagicLockScroll(Serial serial)
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
