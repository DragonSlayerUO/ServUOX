namespace Server.Items
{
    public class Rope : Item, ICommodity
    {
        [Constructible]
        public Rope()
            : this(1)
        {
        }

        [Constructible]
        public Rope(int amount)
            : base(0x14F8)
        {
            Stackable = true;
            Weight = 1.0;
            Amount = amount;
        }

        public Rope(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

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

    public class IronWire : Item, ICommodity
    {
        [Constructible]
        public IronWire()
            : this(1)
        {
        }

        [Constructible]
        public IronWire(int amount)
            : base(0x1876)
        {
            Stackable = true;
            Weight = 5.0;
            Amount = amount;
        }

        public IronWire(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

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

    public class SilverWire : Item, ICommodity
    {
        [Constructible]
        public SilverWire()
            : this(1)
        {
        }

        [Constructible]
        public SilverWire(int amount)
            : base(0x1877)
        {
            Stackable = true;
            Weight = 5.0;
            Amount = amount;
        }

        public SilverWire(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

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

    public class GoldWire : Item, ICommodity
    {
        [Constructible]
        public GoldWire()
            : this(1)
        {
        }

        [Constructible]
        public GoldWire(int amount)
            : base(0x1878)
        {
            Stackable = true;
            Weight = 5.0;
            Amount = amount;
        }

        public GoldWire(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

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

    public class CopperWire : Item, ICommodity
    {
        [Constructible]
        public CopperWire()
            : this(1)
        {
        }

        [Constructible]
        public CopperWire(int amount)
            : base(0x1879)
        {
            Stackable = true;
            Weight = 5.0;
            Amount = amount;
        }

        public CopperWire(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

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

    public class WhiteDriedFlowers : Item
    {
        [Constructible]
        public WhiteDriedFlowers()
            : this(1)
        {
        }

        [Constructible]
        public WhiteDriedFlowers(int amount)
            : base(0xC3C)
        {
            Stackable = true;
            Weight = 1.0;
            Amount = amount;
        }

        public WhiteDriedFlowers(Serial serial)
            : base(serial)
        {
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

    public class GreenDriedFlowers : Item
    {
        [Constructible]
        public GreenDriedFlowers()
            : this(1)
        {
        }

        [Constructible]
        public GreenDriedFlowers(int amount)
            : base(0xC3E)
        {
            Stackable = true;
            Weight = 1.0;
            Amount = amount;
        }

        public GreenDriedFlowers(Serial serial)
            : base(serial)
        {
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

    public class DriedOnions : Item
    {
        [Constructible]
        public DriedOnions()
            : this(1)
        {
        }

        [Constructible]
        public DriedOnions(int amount)
            : base(0xC40)
        {
            Stackable = true;
            Weight = 1.0;
            Amount = amount;
        }

        public DriedOnions(Serial serial)
            : base(serial)
        {
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

    public class DriedHerbs : Item
    {
        [Constructible]
        public DriedHerbs()
            : this(1)
        {
        }

        [Constructible]
        public DriedHerbs(int amount)
            : base(0xC42)
        {
            Stackable = true;
            Weight = 1.0;
            Amount = amount;
        }

        public DriedHerbs(Serial serial)
            : base(serial)
        {
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

    public class HorseShoes : Item
    {
        [Constructible]
        public HorseShoes()
            : base(0xFB6)
        {
            Weight = 3.0;
        }

        public HorseShoes(Serial serial)
            : base(serial)
        {
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

    public class ForgedMetal : Item
    {
        [Constructible]
        public ForgedMetal()
            : base(0xFB8)
        {
            Weight = 5.0;
        }

        public ForgedMetal(Serial serial)
            : base(serial)
        {
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

    public class Whip : Item
    {
        [Constructible]
        public Whip()
            : base(0x166E)
        {
            Weight = 1.0;
        }

        public Whip(Serial serial)
            : base(serial)
        {
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

    public class PaintsAndBrush : Item
    {
        [Constructible]
        public PaintsAndBrush()
            : base(0xFC1)
        {
            Weight = 1.0;
        }

        public PaintsAndBrush(Serial serial)
            : base(serial)
        {
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

    public class PenAndInk : Item
    {
        [Constructible]
        public PenAndInk()
            : base(0xFBF)
        {
            Weight = 1.0;
        }

        public PenAndInk(Serial serial)
            : base(serial)
        {
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

    public class ChiselsNorth : Item
    {
        [Constructible]
        public ChiselsNorth()
            : base(0x1026)
        {
            Weight = 1.0;
        }

        public ChiselsNorth(Serial serial)
            : base(serial)
        {
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

    public class ChiselsWest : Item
    {
        [Constructible]
        public ChiselsWest()
            : base(0x1027)
        {
            Weight = 1.0;
        }

        public ChiselsWest(Serial serial)
            : base(serial)
        {
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

    public class DirtyPan : Item
    {
        [Constructible]
        public DirtyPan()
            : base(0x9E8)
        {
            Weight = 1.0;
        }

        public DirtyPan(Serial serial)
            : base(serial)
        {
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

    public class DirtySmallRoundPot : Item
    {
        [Constructible]
        public DirtySmallRoundPot()
            : base(0x9E7)
        {
            Weight = 1.0;
        }

        public DirtySmallRoundPot(Serial serial)
            : base(serial)
        {
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

    public class DirtyPot : Item
    {
        [Constructible]
        public DirtyPot()
            : base(0x9E6)
        {
            Weight = 1.0;
        }

        public DirtyPot(Serial serial)
            : base(serial)
        {
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

    public class DirtyRoundPot : Item
    {
        [Constructible]
        public DirtyRoundPot()
            : base(0x9DF)
        {
            Weight = 1.0;
        }

        public DirtyRoundPot(Serial serial)
            : base(serial)
        {
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

    public class DirtyFrypan : Item
    {
        [Constructible]
        public DirtyFrypan()
            : base(0x9DE)
        {
            Weight = 1.0;
        }

        public DirtyFrypan(Serial serial)
            : base(serial)
        {
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

    public class DirtySmallPot : Item
    {
        [Constructible]
        public DirtySmallPot()
            : base(0x9DD)
        {
            Weight = 1.0;
        }

        public DirtySmallPot(Serial serial)
            : base(serial)
        {
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

    public class DirtyKettle : Item
    {
        [Constructible]
        public DirtyKettle()
            : base(0x9DC)
        {
            Weight = 1.0;
        }

        public DirtyKettle(Serial serial)
            : base(serial)
        {
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
