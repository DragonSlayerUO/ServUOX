using System;
using Server;
using Server.Items;

public class RoundBasket : BaseContainer
{
    [Constructable]
    public RoundBasket()
        : base(0x990)
    {
        this.Weight = 1.0;
    }

    public RoundBasket(Serial serial)
        : base(serial)
    {
    }

    public override int LabelNumber
    {
        get
        {
            return 1112293;
        }
    }// round basket

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