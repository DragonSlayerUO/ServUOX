using System;

namespace Server.Items
{
    public class GreymistChest : LeatherChest
    {
        public override bool IsArtifact => true;
        [Constructable]
        public GreymistChest()
            : base()
        {
            this.SetHue = 0xCB;

            this.Attributes.BonusMana = 2;
            this.Attributes.SpellDamage = 2;

            this.SetAttributes.Luck = 100;
            this.SetAttributes.NightSight = 1;

            this.SetSelfRepair = 3;

            this.SetPhysicalBonus = 3;
            this.SetFireBonus = 3;
            this.SetColdBonus = 3;
            this.SetPoisonBonus = 3;
            this.SetEnergyBonus = 3;
        }

        public GreymistChest(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1074307;// Greymist Armor
        public override SetItem SetID => SetItem.Acolyte;
        public override int Pieces => 4;
        public override int BasePhysicalResistance => 7;
        public override int BaseFireResistance => 7;
        public override int BaseColdResistance => 3;
        public override int BasePoisonResistance => 4;
        public override int BaseEnergyResistance => 4;
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