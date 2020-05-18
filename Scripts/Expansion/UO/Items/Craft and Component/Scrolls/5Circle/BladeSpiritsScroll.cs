using System;

namespace Server.Items
{
    public class BladeSpiritsScroll : SpellScroll
    {
        [Constructible]
        public BladeSpiritsScroll()
            : this(1)
        {
        }

        [Constructible]
        public BladeSpiritsScroll(int amount)
            : base(32, 0x1F4D, amount)
        {
        }

        public BladeSpiritsScroll(Serial serial)
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
