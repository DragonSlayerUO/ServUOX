using System;

namespace Server.Items
{
    [Flipable(0x2B12, 0x2B13)]
    public class SacrificeSollerets : BaseClothing
    {
        public override bool IsArtifact => true;
        [Constructable]
        public SacrificeSollerets()
            : base(0x2B13, Layer.Shoes)
        {
            this.LootType = LootType.Blessed;
            this.Weight = 1.0;
            this.Hue = 0x226;

            this.SetSelfRepair = 5;
            this.SetPhysicalBonus = 5;
            this.SetFireBonus = 5;
            this.SetColdBonus = 5;
            this.SetPoisonBonus = 5;
            this.SetEnergyBonus = 5;
        }

        public SacrificeSollerets(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1075194;// Sollerets of Sacrifice (Virtue Armor Set)
        public override SetItem SetID => SetItem.Virtue;
        public override int Pieces => 8;
        public override int InitMinHits => 0;
        public override int InitMaxHits => 0;
        public override int AosStrReq => 10;
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