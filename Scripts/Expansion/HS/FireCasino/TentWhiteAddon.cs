
////////////////////////////////////////
//                                    //
//   Generated by CEO's YAAAG - V1.2  //
// (Yet Another Arya Addon Generator) //
//                                    //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
    public class tent_whiteAddon : BaseAddon
    {
        private static int[,] m_AddOnSimpleComponents = new int[,] {
              {3206, -1, 5, 5}, {3206, 3, 5, 5}, {1985, -2, 2, 1}// 1	2	3	
			, {2968, -1, 5, 1}, {3207, -2, 5, 3}, {3222, -4, 4, 1}// 4	5	6	
			, {3207, 3, 5, 3}, {3222, 5, 5, 1}, {1981, 2, 2, 1}// 7	8	9	
			, {2884, 4, 5, 1}, {2884, -1, 5, 1}, {2883, -2, 5, 1}// 14	18	23	
			, {1981, 1, 2, 1}, {1981, -1, 2, 1}, {3206, -2, 5, 5}// 24	29	31	
			, {3206, 4, 5, 5}, {3010, -1, 5, 1}, {1986, 3, 2, 1}// 33	35	37	
			, {2883, 3, 5, 1}, {1981, 0, 2, 1}, {1981, -1, -3, 1}// 39	40	47	
			, {1981, 0, -3, 1}, {1981, 1, -3, 1}, {1981, 2, -3, 1}// 48	49	53	
			, {1983, -2, -3, 1}, {1982, 3, 0, 1}, {1982, 3, 1, 1}// 65	67	68	
			, {1982, 3, -2, 1}, {1982, 3, -1, 1}, {1982, -2, 1, 1}// 74	76	79	
			, {1984, 3, -3, 1}, {1982, -2, -1, 1}, {1982, -2, 0, 1}// 100	106	110	
			, {1982, -2, -2, 1}// 111	
		};



        public override BaseAddonDeed Deed => new tent_whiteAddonDeed();

        [Constructable]
        public tent_whiteAddon()
        {

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent(new AddonComponent(m_AddOnSimpleComponents[i, 0]), m_AddOnSimpleComponents[i, 1], m_AddOnSimpleComponents[i, 2], m_AddOnSimpleComponents[i, 3]);


            AddComplexComponent(this, 497, 3, 4, 1, 1150, -1, "", 1);// 10
            AddComplexComponent(this, 2778, 0, 2, 1, 0, -1, "decorative golden rug", 1);// 11
            AddComplexComponent(this, 2786, 0, 3, 1, 0, -1, "decorative golden rug", 1);// 12
            AddComplexComponent(this, 500, -3, 4, 1, 1150, -1, "", 1);// 13
            AddComplexComponent(this, 2785, 3, 2, 1, 0, -1, "decorative golden rug", 1);// 15
            AddComplexComponent(this, 2786, 1, 3, 1, 0, -1, "decorative golden rug", 1);// 16
            AddComplexComponent(this, 2778, 1, 2, 1, 0, -1, "decorative golden rug", 1);// 17
            AddComplexComponent(this, 503, -3, 2, 1, 1150, -1, "", 1);// 19
            AddComplexComponent(this, 497, -2, 4, 1, 1150, -1, "", 1);// 20
            AddComplexComponent(this, 2778, -1, 2, 1, 0, -1, "decorative golden rug", 1);// 21
            AddComplexComponent(this, 2781, -2, 3, 1, 0, -1, "decorative golden rug", 1);// 22
            AddComplexComponent(this, 2779, 3, 3, 1, 0, -1, "decorative golden rug", 1);// 25
            AddComplexComponent(this, 497, -1, 4, 1, 1150, -1, "", 1);// 26
            AddComplexComponent(this, 2786, -1, 3, 1, 0, -1, "decorative golden rug", 1);// 27
            AddComplexComponent(this, 498, 5, 3, 1, 1150, -1, "", 1);// 28
            AddComplexComponent(this, 2786, 2, 3, 1, 0, -1, "decorative golden rug", 1);// 30
            AddComplexComponent(this, 503, -3, 3, 1, 1150, -1, "", 1);// 32
            AddComplexComponent(this, 2778, 2, 2, 1, 0, -1, "decorative golden rug", 1);// 34
            AddComplexComponent(this, 496, 5, 4, 1, 1150, -1, "", 1);// 36
            AddComplexComponent(this, 498, 5, 2, 1, 1150, -1, "", 1);// 38
            AddComplexComponent(this, 497, 4, 4, 1, 1150, -1, "", 1);// 41
            AddComplexComponent(this, 2783, -2, 2, 1, 0, -1, "decorative golden rug", 1);// 42
            AddComplexComponent(this, 502, 4, -4, 1, 1150, -1, "", 1);// 43
            AddComplexComponent(this, 4611, -1, 0, 1, 1193, -1, "", 1);// 44
            AddComplexComponent(this, 4611, -1, -1, 1, 1193, -1, "", 1);// 45
            AddComplexComponent(this, 4612, 2, 0, 0, 1193, -1, "", 1);// 46
            AddComplexComponent(this, 498, 5, 0, 1, 1150, -1, "", 1);// 50
            AddComplexComponent(this, 2778, 2, -1, 1, 0, -1, "decorative golden rug", 1);// 51
            AddComplexComponent(this, 4612, 2, -1, 0, 1193, -1, "", 1);// 52
            AddComplexComponent(this, 4609, -1, 1, 1, 1193, -1, "", 1);// 54
            AddComplexComponent(this, 2778, -1, 0, 1, 0, -1, "decorative golden rug", 1);// 55
            AddComplexComponent(this, 503, -3, -3, 1, 1150, -1, "", 1);// 56
            AddComplexComponent(this, 4611, 0, -2, 1, 1193, -1, "", 1);// 57
            AddComplexComponent(this, 4612, 2, -2, 0, 1193, -1, "", 1);// 58
            AddComplexComponent(this, 4609, 0, 1, 1, 1193, -1, "", 1);// 59
            AddComplexComponent(this, 2778, 0, 1, 1, 0, -1, "decorative golden rug", 1);// 60
            AddComplexComponent(this, 2784, 2, -3, 1, 0, -1, "decorative golden rug", 1);// 61
            AddComplexComponent(this, 4609, 1, 1, 1, 1193, -1, "", 1);// 64
            AddComplexComponent(this, 2778, 1, 0, 1, 0, -1, "decorative golden rug", 1);// 66
            AddComplexComponent(this, 2785, 3, 1, 1, 0, -1, "decorative golden rug", 1);// 69
            AddComplexComponent(this, 2778, 2, 1, 1, 0, -1, "decorative golden rug", 1);// 70
            AddComplexComponent(this, 502, 0, -4, 1, 1150, -1, "", 1);// 71
            AddComplexComponent(this, 2784, -1, -3, 1, 0, -1, "decorative golden rug", 1);// 72
            AddComplexComponent(this, 2785, 3, 0, 1, 0, -1, "decorative golden rug", 1);// 73
            AddComplexComponent(this, 2778, -1, 1, 1, 0, -1, "decorative golden rug", 1);// 75
            AddComplexComponent(this, 4609, 2, 1, 1, 1193, -1, "", 1);// 77
            AddComplexComponent(this, 2778, 0, 0, 1, 0, -1, "decorative golden rug", 1);// 78
            AddComplexComponent(this, 2778, -1, -2, 1, 0, -1, "decorative golden rug", 1);// 80
            AddComplexComponent(this, 2778, 0, -1, 1, 0, -1, "decorative golden rug", 1);// 81
            AddComplexComponent(this, 2778, 1, 1, 1, 0, -1, "decorative golden rug", 1);// 82
            AddComplexComponent(this, 4611, -1, -2, 1, 1193, -1, "", 1);// 83
            AddComplexComponent(this, 502, 3, -4, 1, 1150, -1, "", 1);// 84
            AddComplexComponent(this, 499, -3, -4, 1, 1150, -1, "", 1);// 85
            AddComplexComponent(this, 4611, 1, -2, 1, 1193, -1, "", 1);// 86
            AddComplexComponent(this, 2785, 3, -1, 1, 0, -1, "decorative golden rug", 1);// 87
            AddComplexComponent(this, 2778, 0, -2, 1, 0, -1, "decorative golden rug", 1);// 88
            AddComplexComponent(this, 502, 1, -4, 1, 1150, -1, "", 1);// 89
            AddComplexComponent(this, 2784, 1, -3, 1, 0, -1, "decorative golden rug", 1);// 90
            AddComplexComponent(this, 2785, 3, -2, 1, 0, -1, "decorative golden rug", 1);// 91
            AddComplexComponent(this, 503, -3, 1, 1, 1150, -1, "", 1);// 92
            AddComplexComponent(this, 2784, 0, -3, 1, 0, -1, "decorative golden rug", 1);// 93
            AddComplexComponent(this, 2778, -1, -1, 1, 0, -1, "decorative golden rug", 1);// 95
            AddComplexComponent(this, 502, 2, -4, 1, 1150, -1, "", 1);// 96
            AddComplexComponent(this, 2778, 1, -1, 1, 0, -1, "decorative golden rug", 1);// 97
            AddComplexComponent(this, 498, 5, -1, 1, 1150, -1, "", 1);// 98
            AddComplexComponent(this, 503, -3, -2, 1, 1150, -1, "", 1);// 99
            AddComplexComponent(this, 498, 5, 1, 1, 1150, -1, "", 1);// 101
            AddComplexComponent(this, 2782, 3, -3, 1, 0, -1, "decorative golden rug", 1);// 102
            AddComplexComponent(this, 2778, 1, -2, 1, 0, -1, "decorative golden rug", 1);// 103
            AddComplexComponent(this, 498, 5, -3, 1, 1150, -1, "", 1);// 104
            AddComplexComponent(this, 503, -3, -1, 1, 1150, -1, "", 1);// 105
            AddComplexComponent(this, 502, -1, -4, 1, 1150, -1, "", 1);// 107
            AddComplexComponent(this, 2778, 2, -2, 1, 0, -1, "decorative golden rug", 1);// 108
            AddComplexComponent(this, 498, 5, -2, 1, 1150, -1, "", 1);// 109
            AddComplexComponent(this, 2778, 2, 0, 1, 0, -1, "decorative golden rug", 1);// 112
            AddComplexComponent(this, 503, -3, 0, 1, 1150, -1, "", 1);// 113
            AddComplexComponent(this, 2783, -2, 0, 1, 0, -1, "decorative golden rug", 1);// 114
            AddComplexComponent(this, 2783, -2, 1, 1, 0, -1, "decorative golden rug", 1);// 115
            AddComplexComponent(this, 2783, -2, -1, 1, 0, -1, "decorative golden rug", 1);// 116
            AddComplexComponent(this, 2783, -2, -2, 1, 0, -1, "decorative golden rug", 1);// 117
            AddComplexComponent(this, 502, -2, -4, 1, 1150, -1, "", 1);// 118
            AddComplexComponent(this, 2780, -2, -3, 1, 0, -1, "decorative golden rug", 1);// 119

        }

        public tent_whiteAddon(Serial serial) : base(serial)
        {
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType)lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    public class tent_whiteAddonDeed : BaseAddonDeed
    {
        public override BaseAddon Addon => new tent_whiteAddon();

        [Constructable]
        public tent_whiteAddonDeed()
        {
            Name = "tent_white";
        }

        public tent_whiteAddonDeed(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0); // Version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}