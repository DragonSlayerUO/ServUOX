using System;

namespace Server.Items
{
    public class SilverEtchedMace : DiamondMace
    {
        [Constructable]
        public SilverEtchedMace()
        {
            Slayer = SlayerName.Exorcism;
        }

        public SilverEtchedMace(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1073532;// silver-etched mace
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}