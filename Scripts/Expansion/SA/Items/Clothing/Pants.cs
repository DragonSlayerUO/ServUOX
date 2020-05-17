using System;

namespace Server.Items
{
    public class GargishClothLegs : BaseClothing
    {
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        [Constructable]
        public GargishClothLegs()
            : this(0)
        {
        }

        [Constructable]
        public GargishClothLegs(int hue)
            : base(0x040A, Layer.Pants, hue)
        {
            Weight = 2.0;
        }

        public override void OnAdded(object parent)
        {
            base.OnAdded(parent);

            if (parent is Mobile)
            {
                if (((Mobile)parent).Female)
                    ItemID = 0x0409;
                else
                    ItemID = 0x040A;
            }
        }

        public GargishClothLegs(Serial serial)
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

    public class FemaleGargishClothLegs : BaseClothing
    {
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        [Constructable]
        public FemaleGargishClothLegs()
            : this(0)
        {
        }

        [Constructable]
        public FemaleGargishClothLegs(int hue)
            : base(0x0409, Layer.Pants, hue)
        {
            Weight = 2.0;
        }

        public FemaleGargishClothLegs(Serial serial)
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

    public class MaleGargishClothLegs : BaseClothing
    {
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        [Constructable]
        public MaleGargishClothLegs()
            : this(0)
        {
        }

        [Constructable]
        public MaleGargishClothLegs(int hue)
            : base(0x040A, Layer.Pants, hue)
        {
            Weight = 2.0;
        }

        public MaleGargishClothLegs(Serial serial)
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
