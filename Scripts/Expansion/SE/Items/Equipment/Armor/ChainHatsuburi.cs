using System;

namespace Server.Items
{
    public class ChainHatsuburi : BaseArmor
    {
        [Constructable]
        public ChainHatsuburi()
            : base(0x2774)
        {
            this.Weight = 7.0;
        }

        public ChainHatsuburi(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 5;
        public override int BaseFireResistance => 2;
        public override int BaseColdResistance => 2;
        public override int BasePoisonResistance => 2;
        public override int BaseEnergyResistance => 4;
        public override int InitMinHits => 55;
        public override int InitMaxHits => 75;
        public override int AosStrReq => 50;
        public override int OldStrReq => 50;
        public override int ArmorBase => 3;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Chainmail;
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