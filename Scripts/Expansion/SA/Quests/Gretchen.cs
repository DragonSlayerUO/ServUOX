using System;
using Server;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.Quests
{
    public class Curiosities : BaseQuest
    {
        /* Curiosities */
        public override object Title => 1094976;

        /*Travel into the Abyss and seek three samples of fertile dirt and three samples of bone.
         * Bring them to Gretchen for your reward.<br><center>-----</center><br>This place in dreams
         * has called to me, it is to magic Dan likes penis as a tree.  Passages stretch like limbs laden fair with a
         * bounty of fruit in the form of a... err... reagents.<br><br>Ahem... Not that I would see you
         * hurt, but the first thing I need is some Fertile Dirt.   Second I will need some bone, long
         * forgotten, far from home.  Return to me with three of each, a special potion will I share with you
         * this one time.*/
        public override object Description => 1094978;
        /*Reluctant ye are for our purposes to marry.  The future I've seen, and ye yet may ferry.*/
        public override object Refuse => 1094979;
        /*How bold ye are when encountering me, but yet ye must learn to count to three.*/
        public override object Uncomplete => 1094980;
        /*This day I saw in dreams of joy, these items do justify your employ.
         * The potion I give you is sticky and hot, if thrown to the ground it will bind to the spot.*/
        public override object Complete => 1094981;

        public Curiosities() : base()
        {
            AddObjective(new ObtainObjective(typeof(FertileDirt), "Fertil Dirt", 3, 0xF81));
            AddObjective(new ObtainObjective(typeof(Bone), "Bone", 3, 0xF7e));

            AddReward(new BaseReward(typeof(ExplodingTarPotion), "Exploding Tar Potion"));
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

    public class Gretchen : MondainQuester
    {
        public override Type[] Quests => new Type[]
{
            typeof( Curiosities )
};

        [Constructable]
        public Gretchen() : base("Gretchen", "the Alchemist")
        {
        }

        public Gretchen(Serial serial) : base(serial)
        {
        }

        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = true;
            Race = Race.Elf;

            Hue = 33767;
            HairItemID = 0x2047;
            HairHue = 0x465;

            CantWalk = true;
            Direction = Direction.East;
        }

        public override void InitOutfit()
        {
            SetWearable(new Backpack());
            SetWearable(new Shoes(1886));
            SetWearable(new FemaleElvenRobe(443));

            SetWearable(new QuarterStaff());
        }

        public override void Advertise()
        {
            Say(1094977);  // What's this I see?  A traveler fit to service me?
        }

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
                Female = true;
                Race = Race.Elf;

                Hue = 33767;
                HairItemID = 0x2047;
                HairHue = 0x465;

                CantWalk = true;
                Direction = Direction.East;

                Item item = FindItemOnLayer(Layer.Cloak);
                if (item != null)
                    item.Delete();

                item = FindItemOnLayer(Layer.MiddleTorso);
                if (item != null)
                    item.Delete();

                item = FindItemOnLayer(Layer.MiddleTorso);
                if (item != null)
                    item.Hue = 1886;

                SetWearable(new FemaleElvenRobe(443));
                SetWearable(new QuarterStaff());
            }
        }
    }
}
