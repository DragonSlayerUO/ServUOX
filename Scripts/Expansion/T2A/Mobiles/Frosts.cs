using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a frost ooze corpse")]
    public class FrostOoze : BaseCreature
    {
        [Constructable]
        public FrostOoze()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a frost ooze";
            Body = 94;
            BaseSoundID = 456;

            SetStr(18, 30);
            SetDex(16, 21);
            SetInt(16, 20);

            SetHits(13, 17);

            SetDamage(3, 9);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Cold, 40, 50);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 10, 20);

            SetSkill(SkillName.MagicResist, 5.1, 10.0);
            SetSkill(SkillName.Tactics, 19.3, 34.0);
            SetSkill(SkillName.Wrestling, 25.3, 40.0);

            Fame = 450;
            Karma = -450;

            VirtualArmor = 38;
        }

        public FrostOoze(Serial serial)
            : base(serial)
        {
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Gems, Utility.RandomMinMax(1, 2));
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

    [CorpseName("a frost spider corpse")]
    public class FrostSpider : BaseCreature
    {
        [Constructable]
        public FrostSpider()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a frost spider";
            Body = 20;
            BaseSoundID = 0x388;

            if (Utility.RandomBool())
                Hue = 1154;

            SetStr(76, 100);
            SetDex(126, 145);
            SetInt(36, 60);

            SetHits(46, 60);
            SetMana(0);

            SetDamage(6, 16);

            SetDamageType(ResistanceType.Physical, 20);
            SetDamageType(ResistanceType.Cold, 80);

            SetResistance(ResistanceType.Physical, 25, 30);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 40, 50);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 10, 20);

            SetSkill(SkillName.MagicResist, 25.1, 40.0);
            SetSkill(SkillName.Tactics, 35.1, 50.0);
            SetSkill(SkillName.Wrestling, 50.1, 65.0);

            Fame = 775;
            Karma = -775;

            VirtualArmor = 28;

            Tamable = true;
            ControlSlots = 1;
            MinTameSkill = 74.7;

            PackItem(new SpidersSilk(7));
        }

        public FrostSpider(Serial serial)
            : base(serial)
        {
        }

        public override FoodType FavoriteFood => FoodType.Meat;
        public override PackInstinct PackInstinct => PackInstinct.Arachnid;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
            AddLoot(LootPack.Poor);
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

    [CorpseName("a frost troll corpse")]
    public class FrostTroll : BaseCreature
    {
        [Constructable]
        public FrostTroll()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a frost troll";
            Body = 55;
            BaseSoundID = 461;

            SetStr(227, 265);
            SetDex(66, 85);
            SetInt(46, 70);

            SetHits(140, 156);

            SetDamage(14, 20);

            SetDamageType(ResistanceType.Physical, 75);
            SetDamageType(ResistanceType.Cold, 25);

            SetResistance(ResistanceType.Physical, 45, 55);
            SetResistance(ResistanceType.Cold, 40, 50);
            SetResistance(ResistanceType.Poison, 5, 10);
            SetResistance(ResistanceType.Energy, 5, 10);

            SetSkill(SkillName.MagicResist, 65.1, 80.0);
            SetSkill(SkillName.Tactics, 80.1, 100.0);
            SetSkill(SkillName.Wrestling, 80.1, 100.0);

            Fame = 4000;
            Karma = -4000;

            VirtualArmor = 50;

            PackItem(new DoubleAxe()); // TODO: Weapon??
        }

        public FrostTroll(Serial serial)
            : base(serial)
        {
        }

        public override int Meat => 2;
        public override int TreasureMapLevel => 1;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Gems);
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
