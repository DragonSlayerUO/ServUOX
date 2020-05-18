namespace Server.Items
{
    public class TeleportScroll : SpellScroll
    {
        [Constructible]
        public TeleportScroll()
            : this(1)
        {
        }

        [Constructible]
        public TeleportScroll(int amount)
            : base(21, 0x1F42, amount)
        {
        }

        public TeleportScroll(Serial serial)
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
