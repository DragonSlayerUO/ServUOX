namespace Server.Items
{
    public class CounterfeitPlatinum : Item
    {
        public override int LabelNumber => 1158686;  // counterfeit platinum

        [Constructible]
        public CounterfeitPlatinum()
            : base(0x1BF9)
        {
            Hue = 2500;
        }

        public CounterfeitPlatinum(Serial serial)
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
