namespace Server.Items
{
    public class Torso : Item
    {
        [Constructible]
        public Torso()
            : base(0x1D9F)
        {
            Weight = 2.0;
        }

        public Torso(Serial serial)
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
