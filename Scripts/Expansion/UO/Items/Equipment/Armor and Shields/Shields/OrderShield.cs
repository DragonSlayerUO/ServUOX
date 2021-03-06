using Server.Engines.Craft;
using Server.Guilds;

namespace Server.Items
{
    [Alterable(typeof(DefBlacksmithy), typeof(GargishOrderShield))]
    public class OrderShield : BaseShield
    {
        [Constructible]
        public OrderShield()
            : base(0x1BC4)
        {
            if (!Core.AOS)
            {
                LootType = LootType.Newbied;
            }

            Weight = 7.0;
        }

        public OrderShield(Serial serial)
            : base(serial)
        {
        }

        public override int BasePhysicalResistance => 1;
        public override int BaseFireResistance => 0;
        public override int BaseColdResistance => 0;
        public override int BasePoisonResistance => 0;
        public override int BaseEnergyResistance => 0;
        public override int InitMinHits => 100;
        public override int InitMaxHits => 125;
        public override int AosStrReq => 95;
        public override int ArmorBase => 30;

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

        public override bool OnEquip(Mobile from)
        {
            return Validate(from) && base.OnEquip(from);
        }

        public override void OnSingleClick(Mobile from)
        {
            if (Validate(Parent as Mobile))
            {
                base.OnSingleClick(from);
            }
        }

        public virtual bool Validate(Mobile m)
        {
            if (Core.AOS || m == null || !m.Player || m.IsStaff())
            {
                return true;
            }

            if (!(m.Guild is Guild g) || g.Type != GuildType.Order)
            {
                m.FixedEffect(0x3728, 10, 13);
                Delete();

                return false;
            }

            return true;
        }
    }
}
