using System;

namespace Server.Items
{
    public class MindBlastScroll : SpellScroll
    {
        [Constructible]
        public MindBlastScroll()
            : this(1)
        {
        }

        [Constructible]
        public MindBlastScroll(int amount)
            : base(36, 0x1F51, amount)
        {
        }

        public MindBlastScroll(Serial serial)
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
