using System;
using Server;
using Server.Items;

public class RoundBasketHandles : BaseContainer
{
    public override int LabelNumber => 1112293;  // round basket

    [Constructible]
    public RoundBasketHandles()
        : base(0x9AC)
    {
        Weight = 1.0;
    }

    public RoundBasketHandles(Serial serial)
        : base(serial)
    {
    }

    public override void Serialize(GenericWriter writer)
    {
        base.Serialize(writer);

        writer.Write(0); // version
    }

    public override void Deserialize(GenericReader reader)
    {
        base.Deserialize(reader);

        int version = reader.ReadInt();
    }
}