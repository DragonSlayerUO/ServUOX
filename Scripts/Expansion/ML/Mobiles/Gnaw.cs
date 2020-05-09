using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a Gnaw corpse")]
    public class Gnaw : DireWolf
    {
        [Constructable]
        public Gnaw()
        {
            Name = "Gnaw";
            Hue = 0x130;

            SetStr(142, 169);
            SetDex(102, 145);
            SetInt(44, 69);

            SetHits(786, 837);
            SetStam(102, 145);
            SetMana(44, 69);

            SetDamage(16, 22);

            SetDamageType(ResistanceType.Physical, 100);

            SetResistance(ResistanceType.Physical, 60, 70);
            SetResistance(ResistanceType.Fire, 50, 60);
            SetResistance(ResistanceType.Cold, 20, 30);
            SetResistance(ResistanceType.Poison, 20, 30);
            SetResistance(ResistanceType.Energy, 23, 40);

            SetSkill(SkillName.Wrestling, 96.3, 119.7);
            SetSkill(SkillName.Tactics, 89.5, 107.7);
            SetSkill(SkillName.MagicResist, 93.6, 112.8);

            Fame = 17500;
            Karma = -17500;

            Tamable = false;

            SetSpecialAbility(SpecialAbility.Rage);
        }
        public override bool CanBeParagon => false;

        public override void OnDeath(Container c)
        {
            for (int i = 0; i < Utility.RandomMinMax(0, 1); i++)
            {
                c.DropItem(Loot.RandomScroll(0, Loot.ArcanistScrollTypes.Length, SpellbookType.Arcanist));
            }

            if (Utility.RandomDouble() < 0.3)
                c.DropItem(new GnawsFang());

            base.OnDeath(c);
        }

        public Gnaw(Serial serial)
            : base(serial)
        {
        }

        public override int Hides => 28;
        public override int Meat => 4;

        public override void GenerateLoot()
        {
            AddLoot(LootPack.FilthyRich, 2);
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
