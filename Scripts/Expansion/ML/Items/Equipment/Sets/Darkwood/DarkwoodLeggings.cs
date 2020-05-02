using System;
using Server.Engines.Craft;

namespace Server.Items
{
    public class DarkwoodLegs : WoodlandLegs
    {
        public override bool IsArtifact => true;
        [Constructable]
        public DarkwoodLegs()
            : base()
        {
            this.Hue = 0x455;
            this.SetHue = 0x494;

            this.Attributes.BonusHits = 2;
            this.Attributes.DefendChance = 5;

            this.SetAttributes.ReflectPhysical = 25;
            this.SetAttributes.BonusStr = 10;
            this.SetAttributes.NightSight = 1;

            this.SetSelfRepair = 3;
            this.SetPhysicalBonus = 2;
            this.SetFireBonus = 5;
            this.SetColdBonus = 5;
            this.SetPoisonBonus = 3;
            this.SetEnergyBonus = 5;
        }

        public DarkwoodLegs(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1073484;// Darkwood Leggings
        public override SetItem SetID => SetItem.Darkwood;
        public override int Pieces => 6;
        public override int BasePhysicalResistance => 8;
        public override int BaseFireResistance => 5;
        public override int BaseColdResistance => 5;
        public override int BasePoisonResistance => 7;
        public override int BaseEnergyResistance => 5;
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

        public override int OnCraft(int quality, bool makersMark, Mobile from, CraftSystem craftSystem, Type typeRes, ITool tool, CraftItem craftItem, int resHue)
        {
            if (resHue > 0)
                this.Hue = resHue;

            Type resourceType = typeRes;

            if (resourceType == null)
                resourceType = craftItem.Resources.GetAt(0).ItemType;

            this.Resource = CraftResources.GetFromType(resourceType);

            switch (this.Resource)
            {
                case CraftResource.Bloodwood:
                    this.Attributes.RegenHits = 2;
                    break;
                case CraftResource.Heartwood:
                    this.Attributes.Luck = 40;
                    break;
                case CraftResource.YewWood:
                    this.Attributes.RegenHits = 1;
                    break;
            }

            return 0;
        }
    }
}