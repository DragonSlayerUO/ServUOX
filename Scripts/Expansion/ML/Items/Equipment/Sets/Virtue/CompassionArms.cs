using System;

namespace Server.Items
{
    [Flipable(0x2B0A, 0x2B0B)]
    public class CompassionArms : BaseArmor
    {
        public override bool IsArtifact => true;
        [Constructable]
        public CompassionArms()
            : base(0x2B0A)
        {
            this.LootType = LootType.Blessed;
            this.Weight = 3.0;
            this.SetHue = 0;
            this.Hue = 0x226;

            this.SetSelfRepair = 5;

            this.SetPhysicalBonus = 5;
            this.SetFireBonus = 5;
            this.SetColdBonus = 5;
            this.SetPoisonBonus = 5;
            this.SetEnergyBonus = 5;
        }

        public CompassionArms(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1075191;// Arms of Compassion (Virtue Armor Set)
        public override SetItem SetID => SetItem.Virtue;
        public override int Pieces => 8;
        public override int BasePhysicalResistance => 8;
        public override int BaseFireResistance => 11;
        public override int BaseColdResistance => 6;
        public override int BasePoisonResistance => 8;
        public override int BaseEnergyResistance => 7;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
        public override int AosStrReq => 60;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Plate;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}