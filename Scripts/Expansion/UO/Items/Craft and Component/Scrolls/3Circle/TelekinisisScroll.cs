namespace Server.Items
{
    public class TelekinisisScroll : SpellScroll
    {
        [Constructible]
        public TelekinisisScroll()
            : this(1)
        {
        }

        [Constructible]
        public TelekinisisScroll(int amount)
            : base(20, 0x1F41, amount)
        {
        }

        public TelekinisisScroll(Serial serial)
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
