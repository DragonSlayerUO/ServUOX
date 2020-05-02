using System;

namespace Server.Items
{
    [Flipable(0x13BB, 0x13C0)]
    public class ChainCoif : BaseArmor
    {
        [Constructable]
        public ChainCoif()
            : base(0x13BB)
        {
            this.Weight = 1.0;
        }

        public ChainCoif(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 4;
        public override int BaseFireResistance => 4;
        public override int BaseColdResistance => 4;
        public override int BasePoisonResistance => 1;
        public override int BaseEnergyResistance => 2;
        public override int InitMinHits => 35;
        public override int InitMaxHits => 60;
        public override int AosStrReq => 60;
        public override int OldStrReq => 20;
        public override int ArmorBase => 28;
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