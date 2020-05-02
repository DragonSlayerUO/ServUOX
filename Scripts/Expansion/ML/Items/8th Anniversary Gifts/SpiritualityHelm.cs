using System;

namespace Server.Items
{
    [Flipable(0x2B10, 0x2B11)]
    public class SpiritualityHelm : BaseArmor
    {
        public override bool IsArtifact => true;
        [Constructable]
        public SpiritualityHelm()
            : base(0x2B10)
        {
            this.LootType = LootType.Blessed;
            this.Weight = 6.0;
            this.SetHue = 0;
            this.Hue = 0x226;

            this.SetSelfRepair = 5;

            this.SetPhysicalBonus = 5;
            this.SetFireBonus = 5;
            this.SetColdBonus = 5;
            this.SetPoisonBonus = 5;
            this.SetEnergyBonus = 5;
        }

        public SpiritualityHelm(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1075237;// Helm of Spirituality (Virtue Armor Set)
        public override SetItem SetID => SetItem.Virtue;
        public override int Pieces => 8;
        public override int BasePhysicalResistance => 8;
        public override int BaseFireResistance => 8;
        public override int BaseColdResistance => 7;
        public override int BasePoisonResistance => 9;
        public override int BaseEnergyResistance => 8;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
        public override int AosStrReq => 25;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;
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