using System;

namespace Server.Items
{
    public class InquisitorsResolution : PlateGloves
    {
        public override bool IsArtifact => true;
        [Constructable]
        public InquisitorsResolution()
        {
            Hue = 0x4F2;
            Attributes.CastRecovery = 3;
            Attributes.LowerManaCost = 8;
            ArmorAttributes.MageArmor = 1;
        }

        public InquisitorsResolution(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1060206;// The Inquisitor's Resolution
        public override int ArtifactRarity => 10;
        public override int BaseColdResistance => 22;
        public override int BaseEnergyResistance => 17;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (version < 1)
            {
                this.ColdBonus = 0;
                this.EnergyBonus = 0;
            }
        }
    }
}