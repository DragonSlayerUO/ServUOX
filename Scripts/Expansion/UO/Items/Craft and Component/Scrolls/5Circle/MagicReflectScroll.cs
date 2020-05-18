using System;

namespace Server.Items
{
    public class MagicReflectScroll : SpellScroll
    {
        [Constructible]
        public MagicReflectScroll()
            : this(1)
        {
        }

        [Constructible]
        public MagicReflectScroll(int amount)
            : base(35, 0x1F50, amount)
        {
        }

        public MagicReflectScroll(Serial serial)
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
