using System;
using Server;

namespace Server.Items
{
    [Flipable(0x971C, 0x9821)]
    public class AdvancedTrainingDummy : TrainingDummy
    {
        [Constructible]
        public AdvancedTrainingDummy() : this(0x971C)
        {
        }

        [Constructible]
        public AdvancedTrainingDummy(int itemID) : base(itemID)
        {
            MinSkill = -25.0;
            MaxSkill = +60.0;
        }

        public override void UpdateItemID()
        {
        }

        public override void BeginSwing()
        {
            ItemID = ItemID + 1;
            base.BeginSwing();
        }

        public override void EndSwing()
        {
            ItemID = ItemID - 1;
            base.EndSwing();
        }

        public AdvancedTrainingDummy(Serial serial)
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

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummyEastAddon : BaseAddon
    {
        public override BaseAddonDeed Deed => new AdvancedTrainingDummyEastDeed();

        [Constructible]
        public AdvancedTrainingDummyEastAddon()
        {
            AddComponent(new AdvancedTrainingDummy(38945), 0, 0, 0);
            AddComponent(new AddonComponent(38962), 0, -1, 0);
            AddComponent(new AddonComponent(38960), 0, 0, 0);
            AddComponent(new AddonComponent(38958), 0, 1, 0);

            AddComponent(new AddonComponent(38959), -1, 1, 0);
            AddComponent(new AddonComponent(38961), 1, 1, 0);
            AddComponent(new AddonComponent(38963), -1, -1, 0);
            AddComponent(new AddonComponent(38957), 1, -1, 0);
        }

        public AdvancedTrainingDummyEastAddon(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummyEastDeed : BaseAddonDeed
    {
        public override BaseAddon Addon => new AdvancedTrainingDummyEastAddon();
        public override int LabelNumber => 1150596;  // advanced training dummy (east)

        [Constructible]
        public AdvancedTrainingDummyEastDeed()
        {
        }

        public AdvancedTrainingDummyEastDeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummySouthAddon : BaseAddon
    {
        public override BaseAddonDeed Deed => new AdvancedTrainingDummySouthDeed();

        [Constructible]
        public AdvancedTrainingDummySouthAddon()
        {
            AddComponent(new AdvancedTrainingDummy(38940), 0, 0, 0);
            AddComponent(new AddonComponent(38955), -1, 0, 0);
            AddComponent(new AddonComponent(38953), 0, 0, 0);
            AddComponent(new AddonComponent(38951), 1, 0, 0);

            AddComponent(new AddonComponent(38954), -1, 1, 0);
            AddComponent(new AddonComponent(38956), -1, -1, 0);

            AddComponent(new AddonComponent(38950), 1, 1, 0);
            AddComponent(new AddonComponent(38952), 1, -1, 0);
        }

        public AdvancedTrainingDummySouthAddon(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class AdvancedTrainingDummySouthDeed : BaseAddonDeed
    {
        public override BaseAddon Addon => new AdvancedTrainingDummySouthAddon();
        public override int LabelNumber => 1150595;  // advanced training dummy (south)

        [Constructible]
        public AdvancedTrainingDummySouthDeed()
        {
        }

        public AdvancedTrainingDummySouthDeed(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}