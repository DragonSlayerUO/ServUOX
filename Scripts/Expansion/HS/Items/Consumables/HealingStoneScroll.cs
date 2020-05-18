using System;

namespace Server.Items
{
    public class HealingStoneScroll : SpellScroll
    {
        [Constructible]
        public HealingStoneScroll()
            : this(1)
        {
        }

        [Constructible]
        public HealingStoneScroll(int amount)
            : base(678, 0x2D9F, amount)
        {
        }

        public HealingStoneScroll(Serial serial)
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