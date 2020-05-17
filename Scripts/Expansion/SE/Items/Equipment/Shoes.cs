using System;
using Server.Engines.Craft;

namespace Server.Items
{

    [Alterable(typeof(DefTailoring), typeof(LeatherTalons), true)]
    [Flipable(0x2797, 0x27E2)]
    public class NinjaTabi : BaseShoes
    {
        [Constructable]
        public NinjaTabi()
            : this(0)
        {
        }

        [Constructable]
        public NinjaTabi(int hue)
            : base(0x2797, hue)
        {
            Weight = 2.0;
        }

        public NinjaTabi(Serial serial)
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

    [Alterable(typeof(DefTailoring), typeof(LeatherTalons), true)]
    [Flipable(0x2796, 0x27E1)]
    public class SamuraiTabi : BaseShoes
    {
        [Constructable]
        public SamuraiTabi()
            : this(0)
        {
        }

        [Constructable]
        public SamuraiTabi(int hue)
            : base(0x2796, hue)
        {
            Weight = 2.0;
        }

        public SamuraiTabi(Serial serial)
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

    [Alterable(typeof(DefTailoring), typeof(LeatherTalons), true)]
    [Flipable(0x2796, 0x27E1)]
    public class Waraji : BaseShoes
    {
        [Constructable]
        public Waraji()
            : this(0)
        {
        }

        [Constructable]
        public Waraji(int hue)
            : base(0x2796, hue)
        {
            Weight = 2.0;
        }

        public Waraji(Serial serial)
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
