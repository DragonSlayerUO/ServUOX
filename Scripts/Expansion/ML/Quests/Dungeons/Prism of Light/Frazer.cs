using System;
using System.Collections.Generic;
using Server.Items;
using Server.Engines.Quests;

namespace Server.Mobiles
{
    public class Frazer : MondainQuester
    {
        [Constructible]
        public Frazer()
            : base("Frazer", "the Vagabond")
        {
            SetSkill(SkillName.ItemID, 64.0, 100.0);
        }

        public Frazer(Serial serial)
            : base(serial)
        {
        }

        public override Type[] Quests => new Type[]
                {
                    typeof(InTheBellyOfTheBeastQuest),
                };
        protected override List<SBInfo> SBInfos => m_SBInfos;
        public override void InitSBInfo()
        {
            m_SBInfos.Add(new SBJewel());
            m_SBInfos.Add(new SBTinker(this));
        }

        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = false;
            Race = Race.Human;

            Hue = 0x840F;
            HairItemID = 0x204A;
            HairHue = 0x45A;
            FacialHairItemID = 0x204D;
            FacialHairHue = 0x45A;
        }

        public override void InitOutfit()
        {
            AddItem(new Shoes(0x735));
            AddItem(new LongPants(0x4C0));
            AddItem(new FancyShirt(0x3));
            AddItem(new JesterHat(0x74A));
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
