using System;

namespace Server.Items
{
    public class GargishClothChest : BaseClothing
    {
        [Constructable]
        public GargishClothChest()
            : this(0)
        {
        }

        [Constructable]
        public GargishClothChest(int hue)
            : base(0x0406, Layer.InnerTorso, hue)
        {
            Weight = 2.0;
        }

        public GargishClothChest(Serial serial)
            : base(serial)
        {
        }

        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;
        public override void OnAdded(object parent)
        {
            base.OnAdded(parent);

            if (parent is Mobile)
            {
                if (((Mobile)parent).Female)
                    ItemID = 0x0405;
                else
                    ItemID = 0x0406;
            }
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

    public class FemaleGargishClothChest : BaseClothing
    {
        [Constructable]
        public FemaleGargishClothChest()
            : this(0)
        {
        }

        [Constructable]
        public FemaleGargishClothChest(int hue)
            : base(0x0405, Layer.InnerTorso, hue)
        {
            Weight = 2.0;
        }

        public FemaleGargishClothChest(Serial serial)
            : base(serial)
        {
        }

        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;
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

    public class MaleGargishClothChest : BaseClothing
    {
        [Constructable]
        public MaleGargishClothChest()
            : this(0)
        {
        }

        [Constructable]
        public MaleGargishClothChest(int hue)
            : base(0x0406, Layer.InnerTorso, hue)
        {
            Weight = 2.0;
        }

        public MaleGargishClothChest(Serial serial)
            : base(serial)
        {
        }

        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;
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
