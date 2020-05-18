using System;

namespace Server.Items
{
    public class SummonEarthElementalScroll : SpellScroll
    {
        [Constructible]
        public SummonEarthElementalScroll()
            : this(1)
        {
        }

        [Constructible]
        public SummonEarthElementalScroll(int amount)
            : base(61, 0x1F6A, amount)
        {
        }

        public SummonEarthElementalScroll(Serial serial)
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
