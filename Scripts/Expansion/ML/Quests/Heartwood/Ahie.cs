using System;
using Server.Items;

namespace Server.Engines.Quests
{
    public class TheKingOfClothingQuest : BaseQuest
    {
        public TheKingOfClothingQuest()
            : base()
        {
            AddObjective(new ObtainObjective(typeof(Kilt), "Kilts", 10, 0x1537));

            AddReward(new BaseReward(typeof(TailorsCraftsmanSatchel), 1074282));
        }

        /* The King of Clothing */
        public override object Title => 1073902;
        /* I have heard noble tales of a fine and proud human garment. An article of clothing 
        fit for both man and god alike. It is called a "kilt" I believe? Could you fetch for 
        me some of these kilts so I that I might revel in their majesty and glory? */
        public override object Description => 1074092;
        /* I will patiently await your reconsideration. */
        public override object Refuse => 1073921;
        /* I will be in your debt if you bring me kilts. */
        public override object Uncomplete => 1073948;
        /* I say truly - that is a magnificent garment! You have more than earned a reward. */
        public override object Complete => 1073974;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }

    public class ThePuffyShirtQuest : BaseQuest
    {
        public ThePuffyShirtQuest()
            : base()
        {
            AddObjective(new ObtainObjective(typeof(FancyShirt), "Fancy Shirts", 10, 0x1EFD));

            AddReward(new BaseReward(typeof(TailorsCraftsmanSatchel), 1074282));
        }

        /* The Puffy Shirt */
        public override object Title => 1073903;
        /* We elves believe that beauty is expressed in all things, including the garments we 
        wear. I wish to understand more about human aesthetics, so please kind traveler - could 
        you bring to me magnificent examples of human fancy shirts? For my thanks, I could teach 
        you more about the beauty of elven vestements. */
        public override object Description => 1074093;
        /* I will patiently await your reconsideration. */
        public override object Refuse => 1073921;
        /* I will be in your debt if you bring me fancy shirts. */
        public override object Uncomplete => 1073949;
        /* I appreciate your service. Now, see what elven hands can create. */
        public override object Complete => 1073973;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }

    public class FromTheGaultierCollectionQuest : BaseQuest
    {
        public FromTheGaultierCollectionQuest()
            : base()
        {
            AddObjective(new ObtainObjective(typeof(StuddedBustierArms), "Studded Bustiers", 10, 0x1C0C));

            AddReward(new BaseReward(typeof(TailorsCraftsmanSatchel), 1074282));
        }

        /* From the Gaultier Collection */
        public override object Title => 1073905;
        /* It is my understanding, the females of humankind actually wear on certain occasions a 
        studded bustier? This is not simply a fanciful tale? Remarkable! It sounds hideously 
        uncomfortable as well as ludicrously impracticle. But perhaps, I simply do not understand 
        the nuances of human clothing. Perhaps, I need to see such a studded bustier for myself? */
        public override object Description => 1074095;
        /* I will patiently await your reconsideration. */
        public override object Refuse => 1073921;
        /* I will be in your debt if you bring me studded bustiers. */
        public override object Uncomplete => 1073951;
        /* Truly, it is worse than I feared. Still, I appreciate your efforts on my behalf. */
        public override object Complete => 1073976;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }

    public class HuteCoutureQuest : BaseQuest
    {
        public HuteCoutureQuest()
            : base()
        {
            AddObjective(new ObtainObjective(typeof(FlowerGarland), "Flower Garlands", 10, 0x2306));
            AddReward(new BaseReward(typeof(TailorsCraftsmanSatchel), 1074282));
        }

        /* H'ute Couture */
        public override object Title => 1073901;
        /* Most human apparel is interesting to elven eyes. But there is one garment - the flower garland - 
        which sounds very elven indeed. Could I see how a human crafts such an object of beauty? In exchange, 
        I could share with you the wonders of elven garments. */
        public override object Description => 1074091;
        /* I will patiently await your reconsideration. */
        public override object Refuse => 1073921;
        /* I will be in your debt if you bring me flower garlands. */
        public override object Uncomplete => 1073947;
        /* I appreciate your service. Now, see what elven hands can create. */
        public override object Complete => 1073973;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }

    public class Ahie : MondainQuester
    {
        [Constructable]
        public Ahie()
            : base("Ahie", "the Cloth Weaver")
        {
            SetSkill(SkillName.Meditation, 60.0, 83.0);
            SetSkill(SkillName.Focus, 60.0, 83.0);
        }

        public Ahie(Serial serial)
            : base(serial)
        {
        }

        public override Type[] Quests => new Type[]
                {
                    typeof(TheKingOfClothingQuest),
                    typeof(ThePuffyShirtQuest),
                    typeof(FromTheGaultierCollectionQuest),
                    typeof(HuteCoutureQuest)
                    //Scale Armor missing Quest https://www.uoguide.com/Scale_Armor
                };
        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = true;
            Race = Race.Elf;

            Hue = 0x853F;
            HairItemID = 0x2FCD;
            HairHue = 0x90;
        }

        public override void InitOutfit()
        {
            AddItem(new ThighBoots(0x901));
            AddItem(new FancyShirt(0x72B));
            AddItem(new Cloak(0x1C));
            AddItem(new Skirt(0x62));
            AddItem(new Circlet());
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }
}
