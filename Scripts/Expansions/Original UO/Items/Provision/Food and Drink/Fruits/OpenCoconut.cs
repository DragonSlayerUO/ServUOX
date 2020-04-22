
namespace Server.Items
{
    public class OpenCoconut : Food
    {
        [Constructable]
        public OpenCoconut()
            : this(1)
        {
        }

        [Constructable]
        public OpenCoconut(int amount)
            : base(amount, 0x1723)
        {
            Weight = 1.0;
            FillFactor = 1;
        }

        public OpenCoconut(Serial serial)
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
