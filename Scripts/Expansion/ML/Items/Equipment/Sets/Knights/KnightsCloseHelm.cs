using System;
using Server.Items;

namespace Server.Items
{
    public class KnightsCloseHelm : CloseHelm
    {
        public override bool IsArtifact => true;
        public override int LabelNumber => 1080156;  // Knight's Close Helm

        public override SetItem SetID => SetItem.Knights;
        public override int Pieces => 6;

        public override int BasePhysicalResistance => 7;
        public override int BaseFireResistance => 7;
        public override int BaseColdResistance => 7;
        public override int BasePoisonResistance => 7;
        public override int BaseEnergyResistance => 7;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;

        [Constructable]
        public KnightsCloseHelm() : base()
        {
            this.Hue = 1150;
            this.Weight = 5;

            this.Attributes.BonusHits = 1;

            this.SetAttributes.BonusHits = 6;
            this.SetAttributes.RegenHits = 2;
            this.SetAttributes.RegenMana = 2;
            this.SetAttributes.AttackChance = 10;
            this.SetAttributes.DefendChance = 10;

            this.SetHue = 1150;
            this.SetPhysicalBonus = 28;
            this.SetFireBonus = 28;
            this.SetColdBonus = 28;
            this.SetPoisonBonus = 28;
            this.SetEnergyBonus = 28;
        }

        public KnightsCloseHelm(Serial serial) : base(serial)
        {
        }

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