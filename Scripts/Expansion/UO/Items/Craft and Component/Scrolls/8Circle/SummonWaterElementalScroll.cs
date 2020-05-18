using System;

namespace Server.Items
{
    public class SummonWaterElementalScroll : SpellScroll
    {
        [Constructible]
        public SummonWaterElementalScroll()
            : this(1)
        {
        }

        [Constructible]
        public SummonWaterElementalScroll(int amount)
            : base(63, 0x1F6C, amount)
        {
        }

        public SummonWaterElementalScroll(Serial serial)
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
