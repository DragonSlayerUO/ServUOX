using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("an air elemental corpse")]
    public class SummonedAirElemental : BaseCreature
    {
        [Constructable]
        public SummonedAirElemental()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "an air elemental";
            Body = 13;
            Hue = 0x4001;
            BaseSoundID = 655;

            SetStr(200);
            SetDex(200);
            SetInt(100);

            SetHits(150);
            SetStam(50);

            SetDamage(6, 9);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Energy, 50);

            SetResistance(ResistanceType.Physical, 40, 50);
            SetResistance(ResistanceType.Fire, 30, 40);
            SetResistance(ResistanceType.Cold, 35, 45);
            SetResistance(ResistanceType.Poison, 50, 60);
            SetResistance(ResistanceType.Energy, 70, 80);

            SetSkill(SkillName.Meditation, 90.0);
            SetSkill(SkillName.EvalInt, 70.0);
            SetSkill(SkillName.Magery, 70.0);
            SetSkill(SkillName.MagicResist, 60.0);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 80.0);

            VirtualArmor = 40;
            ControlSlots = 2;
        }

        public SummonedAirElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();

            if (BaseSoundID == 263)
                BaseSoundID = 655;
        }
    }

    [CorpseName("a daemon corpse")]
    public class SummonedDaemon : BaseCreature
    {
        [Constructable]
        public SummonedDaemon()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = NameList.RandomName("daemon");
            Body = Core.AOS ? 10 : 9;
            BaseSoundID = 357;

            SetStr(200);
            SetDex(110);
            SetInt(150);

            SetDamage(14, 21);

            SetDamageType(ResistanceType.Physical, 0);
            SetDamageType(ResistanceType.Poison, 100);

            SetResistance(ResistanceType.Physical, 45, 55);
            SetResistance(ResistanceType.Fire, 50, 60);
            SetResistance(ResistanceType.Cold, 20, 30);
            SetResistance(ResistanceType.Poison, 70, 80);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.EvalInt, 90.1, 100.0);
            SetSkill(SkillName.Meditation, 90.1, 100.0);
            SetSkill(SkillName.Magery, 90.1, 100.0);
            SetSkill(SkillName.MagicResist, 90.1, 100.0);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 98.1, 99.0);

            VirtualArmor = 58;
            ControlSlots = Core.SE ? 4 : 5;
        }

        public SummonedDaemon(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 125.0;
            }
        }

        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }

        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Regular;
            }
        }// TODO: Immune to poison?

        public override bool CanFly
        {
            get
            {
                return true;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    [CorpseName("an earth elemental corpse")]
    public class SummonedEarthElemental : BaseCreature
    {
        [Constructable]
        public SummonedEarthElemental()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "an earth elemental";
            Body = 14;
            BaseSoundID = 268;

            SetStr(200);
            SetDex(70);
            SetInt(70);

            SetHits(180);

            SetDamage(14, 21);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 65, 75);
            SetResistance(ResistanceType.Fire, 40, 50);
            SetResistance(ResistanceType.Cold, 40, 50);
            SetResistance(ResistanceType.Poison, 40, 50);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.MagicResist, 65.0);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 90.0);

            VirtualArmor = 34;
            ControlSlots = 2;
        }

        public SummonedEarthElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    [CorpseName("a fire elemental corpse")]
    public class SummonedFireElemental : BaseCreature
    {
        [Constructable]
        public SummonedFireElemental()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a fire elemental";
            Body = 15;
            BaseSoundID = 838;

            SetStr(200);
            SetDex(200);
            SetInt(100);

            SetDamage(9, 14);

            SetDamageType(ResistanceType.Physical, 0);
            SetDamageType(ResistanceType.Fire, 100);

            SetResistance(ResistanceType.Physical, 50, 60);
            SetResistance(ResistanceType.Fire, 70, 80);
            SetResistance(ResistanceType.Cold, 0, 10);
            SetResistance(ResistanceType.Poison, 50, 60);
            SetResistance(ResistanceType.Energy, 50, 60);

            SetSkill(SkillName.EvalInt, 90.0);
            SetSkill(SkillName.Magery, 90.0);
            SetSkill(SkillName.MagicResist, 85.0);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 92.0);

            VirtualArmor = 40;
            ControlSlots = 4;

            this.AddItem(new LightSource());
        }

        public SummonedFireElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }

    [CorpseName("a water elemental corpse")]
    public class SummonedWaterElemental : BaseCreature
    {
        [Constructable]
        public SummonedWaterElemental()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a water elemental";
            Body = 16;
            BaseSoundID = 278;

            SetStr(200);
            SetDex(70);
            SetInt(100);

            SetHits(165);

            SetDamage(12, 16);

            SetDamageType(ResistanceType.Physical, 0);
            SetDamageType(ResistanceType.Cold, 100);

            SetResistance(ResistanceType.Physical, 50, 60);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 70, 80);
            SetResistance(ResistanceType.Poison, 45, 55);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.Meditation, 90.0);
            SetSkill(SkillName.EvalInt, 80.0);
            SetSkill(SkillName.Magery, 80.0);
            SetSkill(SkillName.MagicResist, 75.0);
            SetSkill(SkillName.Tactics, 100.0);
            SetSkill(SkillName.Wrestling, 85.0);

            VirtualArmor = 40;
            ControlSlots = 3;
            CanSwim = true;
        }

        public SummonedWaterElemental(Serial serial)
            : base(serial)
        {
        }

        public override double DispelDifficulty
        {
            get
            {
                return 117.5;
            }
        }
        public override double DispelFocus
        {
            get
            {
                return 45.0;
            }
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}
