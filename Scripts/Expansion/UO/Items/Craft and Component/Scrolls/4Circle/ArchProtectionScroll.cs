namespace Server.Items
{
    public class ArchProtectionScroll : SpellScroll
    {
        [Constructible]
        public ArchProtectionScroll()
            : this(1)
        {
        }

        [Constructible]
        public ArchProtectionScroll(int amount)
            : base(25, 0x1F46, amount)
        {
        }

        public ArchProtectionScroll(Serial serial)
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
