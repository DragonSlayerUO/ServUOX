namespace Server.Items
{
    public class HeartwoodLog : BaseLog, ICommodity
    {
        [Constructable]
        public HeartwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public HeartwoodLog(int amount)
            : base(CraftResource.Heartwood, amount)
        {
        }

        public HeartwoodLog(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => 1075066;
        
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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 100, new HeartwoodBoard()))
            {
                return false;
            }

            return true;
        }
    }

    public class BloodwoodLog : BaseLog, ICommodity
    {
        [Constructable]
        public BloodwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public BloodwoodLog(int amount)
            : base(CraftResource.Bloodwood, amount)
        {
        }

        public BloodwoodLog(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => 1075067;

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 100, new BloodwoodBoard()))
            {
                return false;
            }

            return true;
        }
    }

    public class FrostwoodLog : BaseLog, ICommodity
    {
        [Constructable]
        public FrostwoodLog()
            : this(1)
        {
        }

        [Constructable]
        public FrostwoodLog(int amount)
            : base(CraftResource.Frostwood, amount)
        {
        }

        public FrostwoodLog(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => 1075068;

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 100, new FrostwoodBoard()))
            {
                return false;
            }

            return true;
        }
    }

    public class OakLog : BaseLog, ICommodity
    {
        [Constructable]
        public OakLog()
            : this(1)
        {
        }

        [Constructable]
        public OakLog(int amount)
            : base(CraftResource.OakWood, amount)
        {
        }

        public OakLog(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => 1075063;

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 65, new OakBoard()))
            {
                return false;
            }

            return true;
        }
    }

    public class AshLog : BaseLog, ICommodity
    {
        [Constructable]
        public AshLog()
            : this(1)
        {
        }

        [Constructable]
        public AshLog(int amount)
            : base(CraftResource.AshWood, amount)
        {
        }

        public AshLog(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => 1075064;

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 80, new AshBoard()))
            {
                return false;
            }

            return true;
        }
    }

    public class YewLog : BaseLog, ICommodity
    {
        [Constructable]
        public YewLog()
            : this(1)
        {
        }

        [Constructable]
        public YewLog(int amount)
            : base(CraftResource.YewWood, amount)
        {
        }

        public YewLog(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => 1075065;

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

        public override bool Axe(Mobile from, BaseAxe axe)
        {
            if (!TryCreateBoards(from, 95, new YewBoard()))
            {
                return false;
            }

            return true;
        }
    }
}
