using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a skeletal corpse")]
    public class BoneKnight : BaseCreature
    {
        [Constructable]
        public BoneKnight()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a bone knight";
            Body = 57;
            BaseSoundID = 451;

            SetStr(196, 250);
            SetDex(76, 95);
            SetInt(36, 60);

            SetHits(118, 150);

            SetDamage(8, 18);

            SetDamageType(ResistanceType.Physical, 40);
            SetDamageType(ResistanceType.Cold, 60);

            SetResistance(ResistanceType.Physical, 35, 45);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.MagicResist, 65.1, 80.0);
            SetSkill(SkillName.Tactics, 85.1, 100.0);
            SetSkill(SkillName.Wrestling, 85.1, 95.0);

            Fame = 3000;
            Karma = -3000;

            VirtualArmor = 40;
        }

        public BoneKnight(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmunity => Poison.Regular;
        public override bool BleedImmunity => true;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Meager);
        }

        public override void OnDeath(Container CorpseLoot)
        {
            switch (Utility.Random(6))
            {
                case 0:
                    CorpseLoot.DropItem(new PlateArms());
                    break;
                case 1:
                    CorpseLoot.DropItem(new PlateChest());
                    break;
                case 2:
                    CorpseLoot.DropItem(new PlateGloves());
                    break;
                case 3:
                    CorpseLoot.DropItem(new PlateGorget());
                    break;
                case 4:
                    CorpseLoot.DropItem(new PlateLegs());
                    break;
                case 5:
                    CorpseLoot.DropItem(new PlateHelm());
                    break;
            }

            CorpseLoot.DropItem(new Scimitar());
            CorpseLoot.DropItem(new WoodenShield());
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

    [CorpseName("a skeletal corpse")]
    public class BoneMagi : BaseCreature
    {
        [Constructable]
        public BoneMagi()
            : base(AIType.AI_NecroMage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a bone mage";
            Body = 148;
            BaseSoundID = 451;

            SetStr(76, 100);
            SetDex(56, 75);
            SetInt(186, 210);

            SetHits(46, 60);

            SetDamage(3, 7);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 35, 40);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.EvalInt, 60.1, 70.0);
            SetSkill(SkillName.Magery, 60.1, 70.0);
            SetSkill(SkillName.MagicResist, 55.1, 70.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);
            SetSkill(SkillName.Necromancy, 89, 99.1);
            SetSkill(SkillName.SpiritSpeak, 90.0, 99.0);

            Fame = 3000;
            Karma = -3000;

            VirtualArmor = 38;

            PackReg(3);
            PackNecroReg(3, 10);
        }

        public BoneMagi(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmunity => true;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override Poison PoisonImmunity => Poison.Regular;
        public override TribeType Tribe => TribeType.Undead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.LowScrolls);
            AddLoot(LootPack.Potions);
        }

        public override void OnDeath(Container CorpseLoot)
        {
            if (Core.AOS) CorpseLoot.DropItem(new Bone());
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

    [CorpseName("a ghostly corpse")]
    public class Ghoul : BaseCreature
    {
        [Constructable]
        public Ghoul()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a ghoul";
            Body = 153;
            BaseSoundID = 0x482;

            SetStr(76, 100);
            SetDex(76, 95);
            SetInt(36, 60);

            SetHits(46, 60);
            SetMana(0);

            SetDamage(7, 9);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 25, 30);
            SetResistance(ResistanceType.Cold, 20, 30);
            SetResistance(ResistanceType.Poison, 5, 10);
            SetResistance(ResistanceType.Energy, 10, 20);

            SetSkill(SkillName.MagicResist, 45.1, 60.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);

            Fame = 2500;
            Karma = -2500;

            VirtualArmor = 28;
        }

        public Ghoul(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmunity => Poison.Regular;
        public override bool BleedImmunity => true;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
            PackItem(Loot.RandomWeapon());
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

    [CorpseName("a liche's corpse")]
    public class Lich : BaseCreature
    {
        [Constructable]
        public Lich()
            : base(AIType.AI_NecroMage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a lich";
            Body = 24;
            BaseSoundID = 0x3E9;

            SetStr(171, 200);
            SetDex(126, 145);
            SetInt(276, 305);

            SetHits(103, 120);

            SetDamage(24, 26);

            SetDamageType(ResistanceType.Physical, 10);
            SetDamageType(ResistanceType.Cold, 40);
            SetDamageType(ResistanceType.Energy, 50);

            SetResistance(ResistanceType.Physical, 40, 60);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 55, 65);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.Necromancy, 89, 99.1);
            SetSkill(SkillName.SpiritSpeak, 90.0, 99.0);

            SetSkill(SkillName.EvalInt, 100.0);
            SetSkill(SkillName.Magery, 70.1, 80.0);
            SetSkill(SkillName.Meditation, 85.1, 95.0);
            SetSkill(SkillName.MagicResist, 80.1, 100.0);
            SetSkill(SkillName.Tactics, 70.1, 90.0);

            Fame = 8000;
            Karma = -8000;

            VirtualArmor = 50;

            AddItem(new GnarledStaff());
            PackNecroReg(17, 24);
        }

        public Lich(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmunity => Poison.Deadly;
        public override bool BleedImmunity => true;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override bool CanRummageCorpses => true;
        public override int TreasureMapLevel => 3;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Rich);
            AddLoot(LootPack.MedScrolls, 2);
        }

        public override void OnDeath(Container CorpseLoot)
        {
            switch (Utility.Random(25))
            {
                case 0: CorpseLoot.DropItem(new LichFormScroll()); break;
                case 1: CorpseLoot.DropItem(new PoisonStrikeScroll()); break;
                case 2: CorpseLoot.DropItem(new StrangleScroll()); break;
                case 3: CorpseLoot.DropItem(new VengefulSpiritScroll()); break;
                case 4: CorpseLoot.DropItem(new WitherScroll()); break;
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
            _ = reader.ReadInt();
        }
    }

    [CorpseName("a liche's corpse")]
    public class LichLord : BaseCreature
    {
        [Constructable]
        public LichLord()
            : base(AIType.AI_NecroMage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a lich lord";
            Body = 79;
            BaseSoundID = 412;

            SetStr(416, 505);
            SetDex(146, 165);
            SetInt(566, 655);

            SetHits(250, 303);

            SetDamage(11, 13);

            SetDamageType(ResistanceType.Physical, 0);
            SetDamageType(ResistanceType.Cold, 60);
            SetDamageType(ResistanceType.Energy, 40);

            SetResistance(ResistanceType.Physical, 40, 50);
            SetResistance(ResistanceType.Fire, 30, 40);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 50, 60);
            SetResistance(ResistanceType.Energy, 40, 50);

            SetSkill(SkillName.Necromancy, 90, 110.0);
            SetSkill(SkillName.SpiritSpeak, 90.0, 110.0);

            SetSkill(SkillName.EvalInt, 90.1, 100.0);
            SetSkill(SkillName.Magery, 90.1, 100.0);
            SetSkill(SkillName.MagicResist, 150.5, 200.0);
            SetSkill(SkillName.Tactics, 50.1, 70.0);
            SetSkill(SkillName.Wrestling, 60.1, 80.0);

            Fame = 18000;
            Karma = -18000;

            VirtualArmor = 50;

            AddItem(new GnarledStaff());
            PackNecroReg(12, 40);
        }

        public LichLord(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmunity => Poison.Lethal;
        public override bool BleedImmunity => true;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override bool CanRummageCorpses => true;
        public override int TreasureMapLevel => 4;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich);
            AddLoot(LootPack.MedScrolls, 2);
        }

        public override void OnDeath(Container CorpseLoot)
        {
            switch (Utility.Random(15))
            {
                case 0: CorpseLoot.DropItem(new LichFormScroll()); break;
                case 1: CorpseLoot.DropItem(new PoisonStrikeScroll()); break;
                case 2: CorpseLoot.DropItem(new StrangleScroll()); break;
                case 3: CorpseLoot.DropItem(new VengefulSpiritScroll()); break;
                case 4: CorpseLoot.DropItem(new WitherScroll()); break;
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
            _ = reader.ReadInt();
        }
    }

    [CorpseName("a ghostly corpse")]
    public class Shade : BaseCreature
    {
        [Constructable]
        public Shade()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a shade";
            Body = 26;
            Hue = 0x4001;
            BaseSoundID = 0x482;

            SetStr(76, 100);
            SetDex(76, 95);
            SetInt(36, 60);

            SetHits(46, 60);

            SetDamage(7, 11);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Cold, 50);

            SetResistance(ResistanceType.Physical, 25, 30);
            SetResistance(ResistanceType.Cold, 15, 25);
            SetResistance(ResistanceType.Poison, 10, 20);

            SetSkill(SkillName.EvalInt, 55.1, 70.0);
            SetSkill(SkillName.Magery, 55.1, 70.0);
            SetSkill(SkillName.MagicResist, 55.1, 70.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);

            Fame = 4000;
            Karma = -4000;

            VirtualArmor = 28;

            PackReg(10);
        }

        public Shade(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmunity => Poison.Lethal;
        public override bool BleedImmunity => true;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
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

    [CorpseName("a skeletal corpse")]
    public class SkeletalKnight : BaseCreature
    {
        [Constructable]
        public SkeletalKnight()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a skeletal knight";
            Body = 147;
            BaseSoundID = 451;

            SetStr(196, 250);
            SetDex(76, 95);
            SetInt(36, 60);

            SetHits(118, 150);

            SetDamage(8, 18);

            SetDamageType(ResistanceType.Physical, 40);
            SetDamageType(ResistanceType.Cold, 60);

            SetResistance(ResistanceType.Physical, 35, 45);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.MagicResist, 65.1, 80.0);
            SetSkill(SkillName.Tactics, 85.1, 100.0);
            SetSkill(SkillName.Wrestling, 85.1, 95.0);

            Fame = 3000;
            Karma = -3000;

            VirtualArmor = 40;

            AddItem(new Scimitar());
            AddItem(new WoodenShield());
        }

        public SkeletalKnight(Serial serial)
            : base(serial)
        {
        }

        public override Poison PoisonImmunity => Poison.Lethal;
        public override bool BleedImmunity => true;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.Meager);
        }

        public override void OnDeath(Container CorpseLoot)
        {
            switch (Utility.Random(6))
            {
                case 0:
                    CorpseLoot.DropItem(new PlateArms());
                    break;
                case 1:
                    CorpseLoot.DropItem(new PlateChest());
                    break;
                case 2:
                    CorpseLoot.DropItem(new PlateGloves());
                    break;
                case 3:
                    CorpseLoot.DropItem(new PlateGorget());
                    break;
                case 4:
                    CorpseLoot.DropItem(new PlateLegs());
                    break;
                case 5:
                    CorpseLoot.DropItem(new PlateHelm());
                    break;
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
            _ = reader.ReadInt();
        }
    }

    [CorpseName("a skeletal corpse")]
    public class SkeletalMage : BaseCreature
    {
        [Constructable]
        public SkeletalMage()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a skeletal mage";
            Body = 148;
            BaseSoundID = 451;

            SetStr(76, 100);
            SetDex(56, 75);
            SetInt(186, 210);

            SetHits(46, 60);

            SetDamage(3, 7);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 35, 40);
            SetResistance(ResistanceType.Fire, 20, 30);
            SetResistance(ResistanceType.Cold, 50, 60);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 30, 40);

            SetSkill(SkillName.EvalInt, 60.1, 70.0);
            SetSkill(SkillName.Magery, 60.1, 70.0);
            SetSkill(SkillName.MagicResist, 55.1, 70.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);
            SetSkill(SkillName.Necromancy, 89, 99.1);
            SetSkill(SkillName.SpiritSpeak, 90.0, 99.0);

            Fame = 3000;
            Karma = -3000;

            VirtualArmor = 38;

            PackReg(3);
            if (Core.AOS)
            {
                PackNecroReg(3, 10);
                PackItem(new Bone());
            }
        }

        public SkeletalMage(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmunity => true;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;
        public override Poison PoisonImmunity => Poison.Lethal;
        public override TribeType Tribe => TribeType.Undead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Average);
            AddLoot(LootPack.LowScrolls);
            AddLoot(LootPack.Potions);
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

    [CorpseName("a skeletal corpse")]
    public class Skeleton : BaseCreature
    {
        [Constructable]
        public Skeleton()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a skeleton";
            Body = Utility.RandomList(50, 56);
            BaseSoundID = 0x48D;

            SetStr(56, 80);
            SetDex(56, 75);
            SetInt(16, 40);

            SetHits(34, 48);

            SetDamage(3, 7);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Fire, 5, 10);
            SetResistance(ResistanceType.Cold, 25, 40);
            SetResistance(ResistanceType.Poison, 25, 35);
            SetResistance(ResistanceType.Energy, 5, 15);

            SetSkill(SkillName.MagicResist, 45.1, 60.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);

            Fame = 450;
            Karma = -450;

            VirtualArmor = 16;
        }

        public Skeleton(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmunity => true;
        public override Poison PoisonImmunity => Poison.Regular;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override bool IsEnemy(Mobile m)
        {
            if (Region.IsPartOf("Haven Island"))
            {
                return false;
            }
            return base.IsEnemy(m);
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Poor);
        }

        public override void OnDeath(Container CorpseLoot)
        {
            switch (Utility.Random(5))
            {
                case 0:
                    CorpseLoot.DropItem(new BoneArms());
                    break;
                case 1:
                    CorpseLoot.DropItem(new BoneChest());
                    break;
                case 2:
                    CorpseLoot.DropItem(new BoneGloves());
                    break;
                case 3:
                    CorpseLoot.DropItem(new BoneLegs());
                    break;
                case 4:
                    CorpseLoot.DropItem(new BoneHelm());
                    break;
            }

            base.OnDeath(CorpseLoot);
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

    [CorpseName("a ghostly corpse")]
    public class Spectre : BaseCreature
    {
        [Constructable]
        public Spectre()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a spectre";
            Body = 26;
            Hue = 0x4001;
            BaseSoundID = 0x482;

            SetStr(76, 100);
            SetDex(76, 95);
            SetInt(36, 60);

            SetHits(46, 60);

            SetDamage(7, 11);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Cold, 50);

            SetResistance(ResistanceType.Physical, 25, 30);
            SetResistance(ResistanceType.Cold, 15, 25);
            SetResistance(ResistanceType.Poison, 10, 20);

            SetSkill(SkillName.EvalInt, 55.1, 70.0);
            SetSkill(SkillName.Magery, 55.1, 70.0);
            SetSkill(SkillName.MagicResist, 55.1, 70.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);

            Fame = 4000;
            Karma = -4000;

            VirtualArmor = 28;

            PackReg(10);
        }

        public Spectre(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmunity => true;
        public override Poison PoisonImmunity => Poison.Lethal;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
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

    [CorpseName("a ghostly corpse")]
    public class Wraith : BaseCreature
    {
        [Constructable]
        public Wraith()
            : base(AIType.AI_Mage, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a wraith";
            Body = 26;
            Hue = 0x4001;
            BaseSoundID = 0x482;

            SetStr(76, 100);
            SetDex(76, 95);
            SetInt(36, 60);

            SetHits(46, 60);

            SetDamage(7, 11);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Cold, 50);

            SetResistance(ResistanceType.Physical, 25, 30);
            SetResistance(ResistanceType.Cold, 15, 25);
            SetResistance(ResistanceType.Poison, 10, 20);

            SetSkill(SkillName.EvalInt, 55.1, 70.0);
            SetSkill(SkillName.Magery, 55.1, 70.0);
            SetSkill(SkillName.MagicResist, 55.1, 70.0);
            SetSkill(SkillName.Tactics, 45.1, 60.0);
            SetSkill(SkillName.Wrestling, 45.1, 55.0);

            Fame = 4000;
            Karma = -4000;

            VirtualArmor = 28;

            PackReg(10);
        }

        public Wraith(Serial serial)
            : base(serial)
        {
        }
        public override bool BleedImmunity => true;
        public override Poison PoisonImmunity => Poison.Lethal;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
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

    [CorpseName("a rotting corpse")]
    public class Zombie : BaseCreature
    {
        [Constructable]
        public Zombie()
            : base(AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4)
        {
            Name = "a zombie";
            Body = 3;
            BaseSoundID = 471;

            SetStr(46, 70);
            SetDex(31, 50);
            SetInt(26, 40);

            SetHits(28, 42);

            SetDamage(3, 7);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 15, 20);
            SetResistance(ResistanceType.Cold, 20, 30);
            SetResistance(ResistanceType.Poison, 5, 10);

            SetSkill(SkillName.MagicResist, 15.1, 40.0);
            SetSkill(SkillName.Tactics, 35.1, 50.0);
            SetSkill(SkillName.Wrestling, 35.1, 50.0);

            Fame = 600;
            Karma = -600;

            VirtualArmor = 18;

            PackBodyPartOrBones();
        }

        public Zombie(Serial serial)
            : base(serial)
        {
        }

        public override bool BleedImmunity => true;
        public override Poison PoisonImmunity => Poison.Lethal;
        public override TribeType Tribe => TribeType.Undead;
        public override OppositionGroup OppositionGroup => OppositionGroup.FeyAndUndead;

        public override bool IsEnemy(Mobile m)
        {
            if (Region.IsPartOf("Haven Island"))
            {
                return false;
            }

            return base.IsEnemy(m);
        }

        public override void GenerateLoot()
        {
            AddLoot(LootPack.Meager);
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
