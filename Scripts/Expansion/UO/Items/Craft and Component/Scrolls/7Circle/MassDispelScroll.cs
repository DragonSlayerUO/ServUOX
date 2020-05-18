namespace Server.Items
{
    public class MassDispelScroll : SpellScroll
    {
        [Constructible]
        public MassDispelScroll()
            : this(1)
        {
        }

        [Constructible]
        public MassDispelScroll(int amount)
            : base(53, 0x1F62, amount)
        {
        }

        public MassDispelScroll(Serial serial)
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
