namespace Server.Items
{
    public class WeakenScroll : SpellScroll
    {
        [Constructible]
        public WeakenScroll()
            : this(1)
        {
        }

        [Constructible]
        public WeakenScroll(int amount)
            : base(7, 0x1F34, amount)
        {
        }

        public WeakenScroll(Serial serial)
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
