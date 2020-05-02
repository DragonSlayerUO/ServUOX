using System;

namespace Server.Items
{
    public class PlateHatsuburi : BaseArmor
    {
        [Constructable]
        public PlateHatsuburi()
            : base(0x2775)
        {
            this.Weight = 5.0;
        }

        public PlateHatsuburi(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 5;
        public override int BaseFireResistance => 3;
        public override int BaseColdResistance => 2;
        public override int BasePoisonResistance => 2;
        public override int BaseEnergyResistance => 3;
        public override int InitMinHits => 55;
        public override int InitMaxHits => 75;
        public override int AosStrReq => 65;
        public override int OldStrReq => 65;
        public override int ArmorBase => 4;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;
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