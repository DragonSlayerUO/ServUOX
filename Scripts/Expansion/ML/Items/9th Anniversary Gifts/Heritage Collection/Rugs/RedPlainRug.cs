using System;

namespace Server.Items
{
    public class RedPlainRugAddon : BaseAddon
    {
        [Constructible]
        public RedPlainRugAddon()
            : base()
        {
            AddComponent(new LocalizedAddonComponent(0xAC9, 1076588), 1, 1, 0);
            AddComponent(new LocalizedAddonComponent(0xACA, 1076588), -1, -1, 0);
            AddComponent(new LocalizedAddonComponent(0xACB, 1076588), -1, 1, 0);
            AddComponent(new LocalizedAddonComponent(0xACC, 1076588), 1, -1, 0);
            AddComponent(new LocalizedAddonComponent(0xACD, 1076588), -1, 0, 0);
            AddComponent(new LocalizedAddonComponent(0xACE, 1076588), 0, -1, 0);
            AddComponent(new LocalizedAddonComponent(0xACF, 1076588), 1, 0, 0);
            AddComponent(new LocalizedAddonComponent(0xAD0, 1076588), 0, 1, 0);
            AddComponent(new LocalizedAddonComponent(0xAC6, 1076588), 0, 0, 0);
        }

        public RedPlainRugAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new RedPlainRugDeed();
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

    public class RedPlainRugDeed : BaseAddonDeed
    {
        [Constructible]
        public RedPlainRugDeed()
            : base()
        {
            LootType = LootType.Blessed;
        }

        public RedPlainRugDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon => new RedPlainRugAddon();
        public override int LabelNumber => 1076588;// Red plain rug
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