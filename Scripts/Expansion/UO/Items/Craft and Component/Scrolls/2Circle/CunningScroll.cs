namespace Server.Items
{
    public class CunningScroll : SpellScroll
    {
        [Constructible]
        public CunningScroll()
            : this(1)
        {
        }

        [Constructible]
        public CunningScroll(int amount)
            : base(9, 0x1F36, amount)
        {
        }

        public CunningScroll(Serial serial)
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
