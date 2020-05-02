using System;
using Server.Engines.Craft;

namespace Server.Items
{
    [Alterable(typeof(DefBlacksmithy), typeof(Shortblade))]
    [Flipable(0x2D21, 0x2D2D)]
    public class AssassinSpike : BaseKnife
    {
        [Constructable]
        public AssassinSpike()
            : base(0x2D21)
        {
            this.Weight = 4.0;
        }

        public AssassinSpike(Serial serial)
            : base(serial)
        {
        }

        public override WeaponAbility PrimaryAbility => WeaponAbility.InfectiousStrike;
        public override WeaponAbility SecondaryAbility => WeaponAbility.ShadowStrike;
        public override int AosStrengthReq => 15;
        public override int AosMinDamage => 10;
        public override int AosMaxDamage => 12;
        public override int AosSpeed => 50;
        public override float MlSpeed => 2.00f;
        public override int OldStrengthReq => 15;
        public override int OldMinDamage => 10;
        public override int OldMaxDamage => 12;
        public override int OldSpeed => 50;
        public override int DefMissSound => 0x239;
        public override SkillName DefSkill => SkillName.Fencing;
        public override int InitMinHits => 30;// TODO
        public override int InitMaxHits => 60;// TODO
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }
}