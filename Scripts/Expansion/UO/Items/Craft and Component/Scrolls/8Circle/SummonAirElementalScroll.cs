using System;

namespace Server.Items
{
    public class SummonAirElementalScroll : SpellScroll
    {
        [Constructible]
        public SummonAirElementalScroll()
            : this(1)
        {
        }

        [Constructible]
        public SummonAirElementalScroll(int amount)
            : base(59, 0x1F68, amount)
        {
        }

        public SummonAirElementalScroll(Serial serial)
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
