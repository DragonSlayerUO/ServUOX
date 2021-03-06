using System;

namespace Server.Items
{
    public class FreshGreenLadyBug : BaseLight
    {
        public override int LabelNumber => 1071401;  // Fresh Green Lady Bug

        public override int LitItemID => SouthFacing ? 0x2D04 : 0x2D02;

        public override int UnlitItemID => SouthFacing ? 0x2D03 : 0x2D01;

        public bool SouthFacing => ItemID == 0x2D03 || ItemID == 0x2D04;

        [Constructible]
        public FreshGreenLadyBug()
            : base(0x2D04)
        {
            Duration = TimeSpan.Zero; // Never burnt out
            Burning = false;
            Light = LightType.Circle225;
            Weight = 3.0;
        }

        public FreshGreenLadyBug(Serial serial)
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

        public void Flip()
        {
            switch (ItemID)
            {
                case 0x2D01: ItemID = 0x2D03; break;
                case 0x2D02: ItemID = 0x2D04; break;
                case 0x2D03: ItemID = 0x2D01; break;
                case 0x2D04: ItemID = 0x2D02; break;
            }
        }
    }
}
