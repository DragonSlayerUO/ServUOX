using System;

namespace Server.Items
{
    public class EarthquakeScroll : SpellScroll
    {
        [Constructible]
        public EarthquakeScroll()
            : this(1)
        {
        }

        [Constructible]
        public EarthquakeScroll(int amount)
            : base(56, 0x1F65, amount)
        {
        }

        public EarthquakeScroll(Serial serial)
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
