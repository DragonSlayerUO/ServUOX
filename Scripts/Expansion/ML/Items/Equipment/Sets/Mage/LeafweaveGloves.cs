using System;

namespace Server.Items
{
    [Flipable(0x2B75, 0x316C)]
    public class LeafweaveGloves : HideGloves
    {
        public override bool IsArtifact => true;
        [Constructable]
        public LeafweaveGloves()
            : base()
        {
            this.SetHue = 0x47E;

            this.Attributes.RegenMana = 1;
            this.ArmorAttributes.MageArmor = 1;

            this.SetAttributes.BonusInt = 10;
            this.SetAttributes.SpellDamage = 15;

            this.SetSelfRepair = 3;

            this.SetPhysicalBonus = 4;
            this.SetFireBonus = 5;
            this.SetColdBonus = 3;
            this.SetPoisonBonus = 4;
            this.SetEnergyBonus = 4;
        }

        public LeafweaveGloves(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1074299;// Elven Leafweave
        public override SetItem SetID => SetItem.Mage;
        public override int Pieces => 4;
        public override int BasePhysicalResistance => 4;
        public override int BaseFireResistance => 9;
        public override int BaseColdResistance => 3;
        public override int BasePoisonResistance => 6;
        public override int BaseEnergyResistance => 8;
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