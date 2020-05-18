using Server;
using System;

namespace Server.Items
{
    public class GargishEpauletteBearingTheCrestOfBlackthorn7 : Cloak
    {
        public override bool IsArtifact => true;
        public override Race RequiredRace => Race.Gargoyle;
        public override bool CanBeWornByGargoyles => true;

        public override int LabelNumber => 1123326;  // Gargish Epaulette

        [Constructible]
        public GargishEpauletteBearingTheCrestOfBlackthorn7()
        {
            ReforgedSuffix = ReforgedSuffix.Blackthorn;
            ItemID = 0x9986;
            Attributes.RegenMana = 2;
            Attributes.DefendChance = 5;
            Attributes.Luck = 140;
            Hue = 1194;

            Layer = Layer.OuterTorso;
        }

        public GargishEpauletteBearingTheCrestOfBlackthorn7(Serial serial)
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
                MaxHitPoints = 0;
                HitPoints = 0;

                if (Layer != Layer.OuterTorso)
                {
                    if (Parent is Mobile)
                    {
                        ((Mobile)Parent).AddToBackpack(this);
                    }

                    Layer = Layer.OuterTorso;
                }
            }
        }
    }
}