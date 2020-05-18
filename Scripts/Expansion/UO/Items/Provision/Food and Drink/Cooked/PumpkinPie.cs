namespace Server.Items
{
    public class PumpkinPie : Food
    {
        public override int LabelNumber => 1041348;// baked pumpkin pie

        [Constructible]
        public PumpkinPie()
            : base(0x1041)
        {
            Stackable = false;
            Weight = 1.0;
            FillFactor = 5;
        }

        public PumpkinPie(Serial serial)
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
    }
}
