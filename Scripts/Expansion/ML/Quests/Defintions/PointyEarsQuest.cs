using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
    public class PointyEarsQuest : BaseQuest
    {
        public PointyEarsQuest()
            : base()
        {
            AddObjective(new ObtainObjective(typeof(SeveredElfEars), "Severed Elf Ears", 20, 0x312D));

            AddReward(new BaseReward(typeof(TrinketBag), 1072341));
        }

        /* Pointy Ears */
        public override object Title => 1074640;
        /* I've heard ... there's some that will pay a good bounty for pointed ears, much like we used to pay for each 
        wolf skin.  I've got nothing personal against these elves.  It's just business.  You want in on this?  I'm not 
        fussy who I work with. */
        public override object Description => 1074641;
        /* Suit yourself. */
        public override object Refuse => 1074642;
        /* I can't pay a bounty if you don't bring bag the ears. */
        public override object Uncomplete => 1074643;
        /* Here to collect on a bounty? */
        public override object Complete => 1074644;
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
