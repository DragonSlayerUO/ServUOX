using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Flipable(0x4644, 0x4645)]
    public class GargishGlasses : BaseArmor, IRepairable
    {
        public CraftSystem RepairSystem => DefTinkering.CraftSystem;

        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        [Constructible]
        public GargishGlasses()
            : base(0x4644)
        {
            Layer = Layer.Earrings;
            Weight = 2;
        }

        public GargishGlasses(Serial serial)
            : base(serial)
        {
        }

        public override int LabelNumber => 1096713;// Gargish Glasses
        public override int BasePhysicalResistance => 2;
        public override int BaseFireResistance => 4;
        public override int BaseColdResistance => 4;
        public override int BasePoisonResistance => 3;
        public override int BaseEnergyResistance => 2;
        public override int InitMinHits => 36;
        public override int InitMaxHits => 48;
        public override int AosStrReq => 45;
        public override int OldStrReq => 40;
        public override int ArmorBase => 30;
        public override ArmorMaterialType MaterialType => ArmorMaterialType.Leather;
        public override CraftResource DefaultResource => CraftResource.RegularLeather;
        public override ArmorMeditationAllowance DefMedAllowance => ArmorMeditationAllowance.All;

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (version == 0)
            {
                XWeaponAttributesDeserializeHelper(reader, this);
            }
        }
    }
}
