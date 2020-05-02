using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefTailoring), typeof(GargishLeatherLegs))]
    public class LeatherNinjaPants : BaseArmor
    {
        [Constructable]
        public LeatherNinjaPants()
            : base(0x2791)
        {
            this.Weight = 3.0;
        }

        public LeatherNinjaPants(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 2;
        public override int BaseFireResistance => 4;
        public override int BaseColdResistance => 3;
        public override int BasePoisonResistance => 3;
        public override int BaseEnergyResistance => 3;
        public override int InitMinHits => 40;
        public override int InitMaxHits => 50;
        public override int AosStrReq => 10;
        public override int OldStrReq => 10;
        public override int ArmorBase => 3;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Leather;
        public override CraftResource DefaultResource => CraftResource.RegularLeather;
        public override ArmorMeditationAllowance DefMedAllowance => ArmorMeditationAllowance.All;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}