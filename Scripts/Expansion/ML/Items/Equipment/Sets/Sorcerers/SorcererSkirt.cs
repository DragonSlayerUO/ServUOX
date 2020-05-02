using System;
using Server.Items;

namespace Server.Items
{
    public class SorcererSkirt : LeatherSkirt
    {
        public override bool IsArtifact => true;
        public override int LabelNumber => 1080471;  // Sorcerer's Skirt

        public override SetItem SetID => SetItem.Sorcerer;
        public override int Pieces => 6;

        public override int BasePhysicalResistance => 7;
        public override int BaseFireResistance => 7;
        public override int BaseColdResistance => 7;
        public override int BasePoisonResistance => 7;
        public override int BaseEnergyResistance => 7;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;

        [Constructable]
        public SorcererSkirt() : base()
        {
            this.Hue = 1165;
            this.Weight = 1;

            this.Attributes.BonusInt = 1;
            this.Attributes.LowerRegCost = 10;

            this.SetAttributes.BonusInt = 6;
            this.SetAttributes.RegenMana = 2;
            this.SetAttributes.DefendChance = 10;
            this.SetAttributes.LowerManaCost = 5;
            this.SetAttributes.LowerRegCost = 40;

            this.SetHue = 1165;

            this.SetPhysicalBonus = 28;
            this.SetFireBonus = 28;
            this.SetColdBonus = 28;
            this.SetPoisonBonus = 28;
            this.SetEnergyBonus = 28;
        }

        public SorcererSkirt(Serial serial) : base(serial)
        {
        }

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