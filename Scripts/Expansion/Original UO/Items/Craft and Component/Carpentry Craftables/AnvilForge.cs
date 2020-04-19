namespace Server.Items
{
    [Flipable(0xFAF, 0xFB0)]
    [Engines.Craft.Anvil]
    public class Anvil : Item
    {
        [Constructable]
        public Anvil()
            : base(0xFAF)
        {
            Movable = false;
        }

        public Anvil(Serial serial)
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

    [Engines.Craft.Forge]
    public class Forge : Item
    {
        [Constructable]
        public Forge()
            : base(0xFB1)
        {
            Movable = false;
        }

        public Forge(Serial serial)
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
