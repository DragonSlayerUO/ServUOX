using System;

namespace Server.Items
{
    public class EnergyVortexScroll : SpellScroll
    {
        [Constructible]
        public EnergyVortexScroll()
            : this(1)
        {
        }

        [Constructible]
        public EnergyVortexScroll(int amount)
            : base(57, 0x1F66, amount)
        {
        }

        public EnergyVortexScroll(Serial serial)
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
