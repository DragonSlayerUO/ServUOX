using Server;
using System;

namespace Server.Items
{
    public class SkullcapBearingTheCrestOfBlackthorn2 : SkullCap
    {
        public override bool IsArtifact => true;

        [Constructible]
        public SkullcapBearingTheCrestOfBlackthorn2()
            : base()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            WeaponAttributes.HitLowerDefend = 30;
            Attributes.BonusStr = 10;
            Attributes.BonusDex = 5;
            StrRequirement = 45;
            Hue = 66;
        }

        public override int BasePhysicalResistance => 25;
        public override int BaseFireResistance => 10;
        public override int BaseColdResistance => 10;
        public override int BasePoisonResistance => 10;
        public override int BaseEnergyResistance => 10;
        public override int InitMinHits => 255;
        public override int InitMaxHits => 255;

        public SkullcapBearingTheCrestOfBlackthorn2(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1);
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
