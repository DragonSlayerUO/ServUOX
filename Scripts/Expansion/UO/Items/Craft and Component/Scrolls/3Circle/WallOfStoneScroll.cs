namespace Server.Items
{
    public class WallOfStoneScroll : SpellScroll
    {
        [Constructible]
        public WallOfStoneScroll()
            : this(1)
        {
        }

        [Constructible]
        public WallOfStoneScroll(int amount)
            : base(23, 0x1F44, amount)
        {
        }

        public WallOfStoneScroll(Serial serial)
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
