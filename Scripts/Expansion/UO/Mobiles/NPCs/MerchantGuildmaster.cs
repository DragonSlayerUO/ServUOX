namespace Server.Mobiles
{
    public class MerchantGuildmaster : BaseGuildmaster
    {
        [Constructible]
        public MerchantGuildmaster()
            : base("merchant")
        {
            SetSkill(SkillName.ItemID, 85.0, 100.0);
            SetSkill(SkillName.ArmsLore, 85.0, 100.0);
        }

        public MerchantGuildmaster(Serial serial)
            : base(serial)
        {
        }

        public override NpcGuild NpcGuild => NpcGuild.MerchantsGuild;

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
