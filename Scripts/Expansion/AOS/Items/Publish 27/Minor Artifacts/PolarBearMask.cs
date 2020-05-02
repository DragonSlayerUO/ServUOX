using System;

namespace Server.Items
{
    public class PolarBearMask : BearMask
    {
        public override bool IsArtifact => true;
        [Constructable]
        public PolarBearMask()
        {
            Hue = Utility.RandomBool() ? 0x481 : 0x47E;
            ClothingAttributes.SelfRepair = 3;
            Attributes.RegenHits = 2;
            Attributes.NightSight = 1;
        }

        public PolarBearMask(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1070637;
        public override int BasePhysicalResistance => 15;
        public override int BaseColdResistance => 21;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(2);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (version < 2)
            {
                this.Resistances.Physical = 0;
                this.Resistances.Cold = 0;
            }

            if (this.Attributes.NightSight == 0)
                this.Attributes.NightSight = 1;
        }
    }
}