using System;
using Server.Items;

namespace Server.Items
{
    public class ScoutFemaleChest : FemaleStuddedChest
    {
        public override bool IsArtifact { get { return true; } }
        public override int LabelNumber { get { return 1080479; } } // Scout's Female Studded Armor

        public override SetItem SetID { get { return SetItem.Scout; } }
        public override int Pieces { get { return 6; } }

        public override int BasePhysicalResistance { get { return 7; } }
        public override int BaseFireResistance { get { return 7; } }
        public override int BaseColdResistance { get { return 7; } }
        public override int BasePoisonResistance { get { return 7; } }
        public override int BaseEnergyResistance { get { return 7; } }
        public override int InitMinHits { get { return 255; } }
        public override int InitMaxHits { get { return 255; } }

        [Constructable]
        public ScoutFemaleChest() : base()
        {
            this.Hue = 1148;
            this.Weight = 6;

            this.Attributes.BonusDex = 1;
            this.ArmorAttributes.MageArmor = 1;

            this.SetAttributes.BonusDex = 6;
            this.SetAttributes.RegenHits = 2;
            this.SetAttributes.RegenMana = 2;
            this.SetAttributes.AttackChance = 10;
            this.SetAttributes.DefendChance = 10;

            this.SetHue = 0x46D;

            this.SetPhysicalBonus = 28;
            this.SetFireBonus = 28;
            this.SetColdBonus = 28;
            this.SetPoisonBonus = 28;
            this.SetEnergyBonus = 28;
        }

        public ScoutFemaleChest(Serial serial) : base(serial)
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