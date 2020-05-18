using System;
using Server.Items;

namespace Server.Mobiles
{
    public class Messenger : BaseEscortable
    {
        [Constructible]
        public Messenger()
        {
            Title = "the messenger";
        }

        public Messenger(Serial serial)
            : base(serial)
        {
        }

        public override bool CanTeach => true;
        public override bool ClickTitle => false;// Do not display 'the messenger' when single-clicking
        public override void InitOutfit()
        {
            if (Female)
                AddItem(new PlainDress());
            else
                AddItem(new Shirt(GetRandomHue()));

            int lowHue = GetRandomHue();

            AddItem(new ShortPants(lowHue));

            if (Female)
                AddItem(new Boots(lowHue));
            else
                AddItem(new Shoes(lowHue));

            //if ( !Female )
            //AddItem( new BodySash( lowHue ) );

            //AddItem( new Cloak( GetRandomHue() ) );

            //if ( !Female )
            //AddItem( new Longsword() );

            switch (Utility.Random(4))
            {
                case 0:
                    AddItem(new ShortHair(Utility.RandomHairHue()));
                    break;
                case 1:
                    AddItem(new TwoPigTails(Utility.RandomHairHue()));
                    break;
                case 2:
                    AddItem(new ReceedingHair(Utility.RandomHairHue()));
                    break;
                case 3:
                    AddItem(new KrisnaHair(Utility.RandomHairHue()));
                    break;
            }

            PackItem(Loot.PackGold(200, 250));
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

        private static int GetRandomHue()
        {
            switch (Utility.Random(6))
            {
                default:
                case 0:
                    return 0;
                case 1:
                    return Utility.RandomBlueHue();
                case 2:
                    return Utility.RandomGreenHue();
                case 3:
                    return Utility.RandomRedHue();
                case 4:
                    return Utility.RandomYellowHue();
                case 5:
                    return Utility.RandomNeutralHue();
            }
        }
    }
}
