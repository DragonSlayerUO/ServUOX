using System;

namespace Server.Items
{
    public class ShadowDancerLeggings : LeatherLegs
    {
        public override bool IsArtifact => true;
        [Constructable]
        public ShadowDancerLeggings()
        {
            Hue = 0x455;
            SkillBonuses.SetValues(0, SkillName.Stealth, 20.0);
            SkillBonuses.SetValues(1, SkillName.Stealing, 20.0);
        }

        public ShadowDancerLeggings(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1061598;// Shadow Dancer Leggings
        public override int ArtifactRarity => 11;
        public override int BasePhysicalResistance => 17;
        public override int BasePoisonResistance => 18;
        public override int BaseEnergyResistance => 18;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            if (version < 1)
            {
                if (this.ItemID == 0x13CB)
                    this.ItemID = 0x13D2;

                this.PhysicalBonus = 0;
                this.PoisonBonus = 0;
                this.EnergyBonus = 0;
            }
        }
    }
}