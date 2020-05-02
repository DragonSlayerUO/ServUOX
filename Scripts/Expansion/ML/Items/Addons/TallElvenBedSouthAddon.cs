using System;

namespace Server.Items
{
    public class TallElvenBedSouthAddon : BaseAddon
    {
        [Constructable]
        public TallElvenBedSouthAddon()
        {
            AddComponent(new AddonComponent(0x3058), 0, 0, 0); // angolo alto sx
            AddComponent(new AddonComponent(0x3057), -1, 1, 0); // angolo basso sx
            AddComponent(new AddonComponent(0x3059), 0, -1, 0); // angolo alto dx
            AddComponent(new AddonComponent(0x3056), 0, 1, 0); // angolo basso dx
        }

        public TallElvenBedSouthAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new TallElvenBedSouthDeed();
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }

    public class TallElvenBedSouthDeed : BaseAddonDeed
    {
        [Constructable]
        public TallElvenBedSouthDeed()
        {
        }

        public TallElvenBedSouthDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon => new TallElvenBedSouthAddon();
        public override int LabelNumber => 1072858;// tall elven bed (south)
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}