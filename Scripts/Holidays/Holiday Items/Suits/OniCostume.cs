using System;
using Server;

namespace Server.Items
{
    public class OniCostume : BaseCostume
    {
        public override string CreatureName => "oni";

        [Constructable]
        public OniCostume() : base()
        {
            this.CostumeBody = 241;
        }

        public override int LabelNumber => 1114242;// oni costume

        public OniCostume(Serial serial) : base(serial)
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

            int version = reader.ReadInt();
        }
    }
}
