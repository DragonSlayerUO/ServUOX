namespace Server.Items
{
    public abstract class BaseBashing : BaseMeleeWeapon
    {
        public BaseBashing(int itemID)
            : base(itemID)
        {
        }

        public BaseBashing(Serial serial)
            : base(serial)
        {
        }

        public override int DefHitSound => 0x233;
        public override int DefMissSound => 0x239;
        public override SkillName DefSkill => SkillName.Macing;
        public override WeaponType DefType => WeaponType.Bashing;
        public override WeaponAnimation DefAnimation => WeaponAnimation.Bash1H;
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

        public override void OnHit(Mobile attacker, IDamageable defender, double damageBonus)
        {
            base.OnHit(attacker, defender, damageBonus);

            if (defender is Mobile)
            {
                ((Mobile)defender).Stam -= Utility.Random(3, 3); // 3-5 points of stamina loss
            }
        }

        public override double GetBaseDamage(Mobile attacker)
        {
            double damage = base.GetBaseDamage(attacker);

            if (!Core.AOS && (attacker.Player || attacker.Body.IsHuman) && Layer == Layer.TwoHanded && (attacker.Skills[SkillName.Anatomy].Value / 400.0) >= Utility.RandomDouble())
            {
                damage *= 1.5;

                attacker.SendMessage("You deliver a crushing blow!"); // Is this not localized?
                attacker.PlaySound(0x11C);
            }

            return damage;
        }
    }
}