using System;

namespace Server.Items
{
    public class IncognitoScroll : SpellScroll
    {
        [Constructible]
        public IncognitoScroll()
            : this(1)
        {
        }

        [Constructible]
        public IncognitoScroll(int amount)
            : base(34, 0x1F4F, amount)
        {
        }

        public IncognitoScroll(Serial serial)
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
