using System;
using Server.Items;
using Server.Engines.Quests;

namespace Server.Mobiles
{
    public class Kane : MondainQuester
    {
        public override Type[] Quests => new Type[]
        {
            typeof( DoughtyWarriorsQuest )
        };

        [Constructable]
        public Kane()
            : base("Kane", "the Master of Arms")
        {
            //if (!(this is MondainQuester))
            //    Name = "Kane";
            // Title = "the Master of Arms";
        }

        public Kane(Serial serial)
            : base(serial)
        {
        }

        public override void InitBody()
        {
            InitStats(100, 100, 25);

            Female = false;
            Race = Race.Human;

            //Hue = 0x840C;
            HairItemID = 0x203C;
            HairHue = 0x3B3;
        }

        public override void InitOutfit()
        {
            AddItem(new PlateArms());
            AddItem(new PlateChest());
            AddItem(new PlateGloves());
            AddItem(new StuddedGorget());
            AddItem(new PlateLegs());

            switch (Utility.Random(4))
            {
                case 0: AddItem(new PlateHelm()); break;
                case 1: AddItem(new NorseHelm()); break;
                case 2: AddItem(new CloseHelm()); break;
                case 3: AddItem(new Helmet()); break;
            }

            switch (Utility.Random(3))
            {
                case 0: AddItem(new BodySash(0x482)); break;
                case 1: AddItem(new Doublet(0x482)); break;
                case 2: AddItem(new Tunic(0x482)); break;
            }

            AddItem(new Broadsword());

            Item shield = new MetalKiteShield();

            shield.Hue = Utility.RandomNondyedHue();

            AddItem(shield);

            switch (Utility.Random(2))
            {
                case 0: AddItem(new Boots()); break;
                case 1: AddItem(new ThighBoots()); break;
            }

            PackItem(Loot.PackGold(100, 200));
            Blessed = true;
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
