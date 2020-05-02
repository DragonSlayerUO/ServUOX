using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefTailoring), typeof(FemaleGargishLeatherChest))]
    [Flipable(0x1c06, 0x1c07)]
    public class FemaleLeatherChest : BaseArmor
    {
        [Constructable]
        public FemaleLeatherChest()
            : base(0x1C06)
        {
            this.Weight = 1.0;
        }

        public FemaleLeatherChest(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 2;
        public override int BaseFireResistance => 4;
        public override int BaseColdResistance => 3;
        public override int BasePoisonResistance => 3;
        public override int BaseEnergyResistance => 3;
        public override int InitMinHits => 30;
        public override int InitMaxHits => 40;
        public override int AosStrReq => 25;
        public override int OldStrReq => 15;
        public override int ArmorBase => 13;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Leather;
        public override CraftResource DefaultResource => CraftResource.RegularLeather;
        public override ArmorMeditationAllowance DefMedAllowance => ArmorMeditationAllowance.All;
        public override bool AllowMaleWearer => false;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}