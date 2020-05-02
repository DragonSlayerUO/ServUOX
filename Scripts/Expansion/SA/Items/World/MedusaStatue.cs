using System;

namespace Server.Items
{
    public class MedusaStatue : Item
    {
        public override bool IsArtifact => true;
        [Constructable]
        public MedusaStatue()
            : base(0x40BC)
        {
            this.Name = "Medusa";
            this.Weight = 10;
        }

        public MedusaStatue(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1113626;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}