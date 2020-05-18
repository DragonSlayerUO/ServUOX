using Server.Spells.First;

namespace Server.Items
{
    public class ClumsyWand : BaseWand
    {
        [Constructible]
        public ClumsyWand()
            : base(WandEffect.Clumsiness, 5, 30)
        {
        }

        public ClumsyWand(Serial serial)
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
            Cast(new ClumsySpell(from, this));
        }
    }
}
