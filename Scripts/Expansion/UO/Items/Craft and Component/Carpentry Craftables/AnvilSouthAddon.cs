namespace Server.Items
{
    public class AnvilSouthAddon : BaseAddon
    {
        [Constructible]
        public AnvilSouthAddon()
        {
            AddComponent(new AnvilComponent(0xFB0), 0, 0, 0);
        }

        public AnvilSouthAddon(Serial serial) : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new AnvilSouthDeed();

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

    public class AnvilSouthDeed : BaseAddonDeed
    {
        [Constructible]
        public AnvilSouthDeed()
        {
        }

        public AnvilSouthDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon => new AnvilSouthAddon();
        public override int LabelNumber => 1044334;// anvil (south)
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
