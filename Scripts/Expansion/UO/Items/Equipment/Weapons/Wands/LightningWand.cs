using Server.Spells.Fourth;

namespace Server.Items
{
    public class LightningWand : BaseWand
    {
        [Constructible]
        public LightningWand()
            : base(WandEffect.Lightning, 5, Core.ML ? 109 : 20)
        {
        }

        public LightningWand(Serial serial)
            : base(serial)
        {
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

        public override void OnWandUse(Mobile from)
        {
            Cast(new LightningSpell(from, this));
        }
    }
}
