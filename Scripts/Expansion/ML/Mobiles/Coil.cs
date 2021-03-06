using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a coil corpse")]
    public class Coil : SilverSerpent
    {
        [Constructible]
        public Coil()
            : base()
        {
            ActiveSpeed = 0.1;
            PassiveSpeed = 0.2;

            Name = "Coil";

            Hue = 0x3F;
            BaseSoundID = 0xDB;

            SetStr(205, 343);
            SetDex(202, 283);
            SetInt(88, 142);

            SetHits(628, 1291);

            SetDamage(19, 28);

            SetDamageType(ResistanceType.Physical, 50);
            SetDamageType(ResistanceType.Poison, 50);

            SetResistance(ResistanceType.Physical, 56, 62);
            SetResistance(ResistanceType.Fire, 25, 29);
            SetResistance(ResistanceType.Cold, 25, 30);
            SetResistance(ResistanceType.Poison, 100);
            SetResistance(ResistanceType.Energy, 27, 30);

            SetSkill(SkillName.Wrestling, 124.5, 134.5);
            SetSkill(SkillName.Tactics, 130.2, 142.0);
            SetSkill(SkillName.MagicResist, 102.3, 113.0);
            SetSkill(SkillName.Anatomy, 120.8, 138.1);
            SetSkill(SkillName.Poisoning, 110.1, 133.4);

            Fame = 17500;
            Karma = -17500;

            PackItem(Loot.PackGem(2));
            PackItem(new Bone());

            for (int i = 0; i < Utility.RandomMinMax(0, 1); i++)
            {
                PackItem(Loot.RandomScroll(0, Loot.ArcanistScrollTypes.Length, SpellbookType.Arcanist));
            }

            SetWeaponAbility(WeaponAbility.MortalStrike);
        }

        public Coil(Serial serial)
            : base(serial)
        {
        }

        public override Poison HitPoison => Poison.Lethal;
        public override Poison PoisonImmunity => Poison.Lethal;
        public override bool GivesMLMinorArtifact => true;
        public override int Hides => 48;
        public override int Meat => 1;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.AosUltraRich, 3);
        }

        public override void OnDeath(Container c)
        {
            c.DropItem(new CoilsFang());

            if (Utility.RandomDouble() < 0.025)
            {
                switch (Utility.Random(5))
                {
                    case 0:
                        c.DropItem(new AssassinChest());
                        break;
                    case 1:
                        c.DropItem(new DeathGloves());
                        break;
                    case 2:
                        c.DropItem(new LeafweaveLegs());
                        break;
                    case 3:
                        c.DropItem(new HunterLegs());
                        break;
                    case 4:
                        c.DropItem(new MyrmidonLegs());
                        break;
                }
            }

            base.OnDeath(c);
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
