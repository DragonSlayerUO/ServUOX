using System;
using Server.Items;
using Server.Engines.Quests;

namespace Server.Mobiles
{
    public class Tillanil : MondainQuester
    {
        [Constructible]
        public Tillanil()
            : base("Tillanil", "the Wine Tender")
        {
            SetSkill(SkillName.Meditation, 60.0, 83.0);
            SetSkill(SkillName.Focus, 60.0, 83.0);
        }

        public Tillanil(Serial serial)
            : base(serial)
        {
        }

        public override Type[] Quests => new Type[]
                {
                    typeof(TheSongOfTheWindQuest),
                    typeof(BeerGogglesQuest),
                    typeof(MessageInBottleQuest)
                };
        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = true;
            Race = Race.Elf;

            Hue = 0x8383;
            HairItemID = 0x2FD0;
            HairHue = 0x127;
        }

        public override void InitOutfit()
        {
            AddItem(new Sandals(0x1BB));
            AddItem(new Tunic(0x712));
            AddItem(new ShortPants(0x30));
        }

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
    }
}
