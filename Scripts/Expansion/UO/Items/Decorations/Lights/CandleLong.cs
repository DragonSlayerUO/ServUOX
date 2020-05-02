using System;

namespace Server.Items
{
    public class CandleLong : BaseLight
    {
        [Constructable]
        public CandleLong()
            : base(0x1433)
        {
            if (Burnout)
                this.Duration = TimeSpan.FromMinutes(30);
            else
                this.Duration = TimeSpan.Zero;

            this.Burning = false;
            this.Light = LightType.Circle150;
            this.Weight = 1.0;
        }

        public CandleLong(Serial serial)
            : base(serial)
        {
        }

        public override int LitItemID => 0x1430;
        public override int UnlitItemID => 0x1433;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}