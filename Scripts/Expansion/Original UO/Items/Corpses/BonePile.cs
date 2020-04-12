namespace Server.Items
{
    [FlipableAttribute(0x1B09, 0x1B10)]
    public class BonePile : Item, IScissorable
    {
        [Constructable]
        public BonePile()
            : base(0x1B09 + Utility.Random(8))
        {
            Stackable = false;
            Weight = 10.0;
        }

        public BonePile(Serial serial)
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

        public bool Scissor(Mobile from, Scissors scissors)
        {
            if (Deleted || !from.CanSee(this))
            {
                return false;
            }

            base.ScissorHelper(from, new Bone(), Utility.RandomMinMax(10, 15));

            return true;
        }
    }
}
