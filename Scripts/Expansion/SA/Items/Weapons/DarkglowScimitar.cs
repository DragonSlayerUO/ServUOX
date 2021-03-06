using System;

namespace Server.Items
{
    public class DarkglowScimitar : RadiantScimitar
    {
        public override bool IsArtifact => true;
        [Constructible]
        public DarkglowScimitar()
        {
            WeaponAttributes.HitDispel = 10;
        }

        public DarkglowScimitar(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1073542;// darkglow scimitar
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