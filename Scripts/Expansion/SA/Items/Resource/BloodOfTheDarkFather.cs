using System;

namespace Server.Items
{
    public class BloodOfTheDarkFather : Item, ICommodity
    {
        [Constructable]
        public BloodOfTheDarkFather()
            : this(1)
        {
        }

        [Constructable]
        public BloodOfTheDarkFather(int amount)
            : base(0x9D7F)
        {
            this.Hue = 2741;
            this.Stackable = true;
            this.Amount = amount;
        }

        public BloodOfTheDarkFather(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

        public override int LabelNumber => 1157343;// Blood of the Dark Father
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
