using System;

namespace Server.Items
{
    public class ArcanicRuneStone : Item, ICommodity
    {
        [Constructable]
        public ArcanicRuneStone()
            : this(1)
        {
        }

        [Constructable]
        public ArcanicRuneStone(int amount)
            : base(0x573C)
        {
            this.Stackable = true;
            this.Amount = amount;
        }

        public ArcanicRuneStone(Serial serial)
            : base(serial)
        {
        }

        TextDefinition ICommodity.Description => LabelNumber;
        bool ICommodity.IsDeedable => true;

        public override int LabelNumber => 1113352;// arcanic rune stone
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
