using System;

namespace Server.Items
{
    [Flipable(0x2B0C, 0x2B0D)]
    public class ValorGauntlets : BaseArmor
    {
        public override bool IsArtifact => true;
        [Constructable]
        public ValorGauntlets()
            : base(0x2B0C)
        {
            this.LootType = LootType.Blessed;
            this.Weight = 4.0;
            this.SetHue = 0;
            this.Hue = 0x226;

            this.SetSelfRepair = 5;

            this.SetPhysicalBonus = 5;
            this.SetFireBonus = 5;
            this.SetColdBonus = 5;
            this.SetPoisonBonus = 5;
            this.SetEnergyBonus = 5;
        }

        public ValorGauntlets(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1075238;// Gauntlets of Valor (Virtue Armor Set)
        public override SetItem SetID => SetItem.Virtue;
        public override int Pieces => 8;
        public override int BasePhysicalResistance => 6;
        public override int BaseFireResistance => 6;
        public override int BaseColdResistance => 8;
        public override int BasePoisonResistance => 9;
        public override int BaseEnergyResistance => 6;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
        public override int AosStrReq => 50;
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