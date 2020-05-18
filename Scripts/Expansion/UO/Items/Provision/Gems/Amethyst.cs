namespace Server.Items
{
    public class Amethyst : Item, IGem
    {
        [Constructible]
        public Amethyst()
            : this(1)
        {
        }

        [Constructible]
        public Amethyst(int amount)
            : base(0xF16)
        {
            Stackable = true;
            Amount = amount;
        }

        public Amethyst(Serial serial)
            : base(serial)
        {
        }

        public override double DefaultWeight => 0.1;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
        }
    }
}
