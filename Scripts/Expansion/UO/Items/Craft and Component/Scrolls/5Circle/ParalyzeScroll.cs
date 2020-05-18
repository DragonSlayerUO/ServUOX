using System;

namespace Server.Items
{
    public class ParalyzeScroll : SpellScroll
    {
        [Constructible]
        public ParalyzeScroll()
            : this(1)
        {
        }

        [Constructible]
        public ParalyzeScroll(int amount)
            : base(37, 0x1F52, amount)
        {
        }

        public ParalyzeScroll(Serial serial)
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
