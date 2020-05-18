using System;

namespace Server.Items
{
    public class DeadWood : BaseReagent, ICommodity
    {
        [Constructible]
        public DeadWood()
            : this(1)
        {
        }

        [Constructible]
        public DeadWood(int amount)
            : base(0xF90, amount)
        {
        }

        public DeadWood(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;
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