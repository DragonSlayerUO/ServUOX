using System;

namespace Server.Items
{
    public class ConfusionBlastPotion : BaseConfusionBlastPotion
    {
        [Constructible]
        public ConfusionBlastPotion()
            : base(PotionEffect.ConfusionBlast)
        {
        }

        public ConfusionBlastPotion(Serial serial)
            : base(serial)
        {
        }

        public override int Radius => 5;
        public override int LabelNumber => 1072105;// a Confusion Blast potion
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