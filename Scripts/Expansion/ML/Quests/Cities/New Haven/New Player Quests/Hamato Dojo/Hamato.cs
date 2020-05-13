using System;
using Server.Items;
using Server.Engines.Quests;

namespace Server.Mobiles
{
    public class Hamato : MondainQuester
    {
        public override Type[] Quests => new Type[]
                {
                    typeof(TheWayOfTheSamuraiQuest)
                };

        public override bool IsActiveVendor => true;
        public override void InitSBInfo()
        {
            m_SBInfos.Add(new SBKeeperOfBushido());
        }

        [Constructable]
        public Hamato()
            : base("Hamato", "the Bushido Instructor")
        {
            SetSkill(SkillName.Anatomy, 120.0, 120.0);
            SetSkill(SkillName.Parry, 120.0, 120.0);
            SetSkill(SkillName.Healing, 120.0, 120.0);
            SetSkill(SkillName.Tactics, 120.0, 120.0);
            SetSkill(SkillName.Swords, 120.0, 120.0);
            SetSkill(SkillName.Bushido, 120.0, 120.0);
        }

        public Hamato(Serial serial)
            : base(serial)
        {
        }

        public override void Advertise()
        {
            Say(1078134); // Seek me to learn the way of the samurai.
        }

        public override void OnOfferFailed()
        {
            Say(1077772); // I cannot teach you, for you know all I can teach!
        }

        public override void InitBody()
        {
            Female = false;
            CantWalk = true;
            Race = Race.Human;

            base.InitBody();
        }

        public override void InitOutfit()
        {
            AddItem(new Backpack());
            AddItem(new NoDachi());
            AddItem(new NinjaTabi());
            AddItem(new PlateSuneate());
            AddItem(new LightPlateJingasa());
            AddItem(new LeatherDo());
            AddItem(new LeatherHiroSode());
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
