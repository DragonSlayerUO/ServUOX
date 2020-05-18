namespace Server.Items
{
    public class FireFieldScroll : SpellScroll
    {
        [Constructible]
        public FireFieldScroll()
            : this(1)
        {
        }

        [Constructible]
        public FireFieldScroll(int amount)
            : base(27, 0x1F48, amount)
        {
        }

        public FireFieldScroll(Serial serial)
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
