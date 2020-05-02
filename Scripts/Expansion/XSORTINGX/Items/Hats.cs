using System;
using System.Collections.Generic;
using Server.Engines.Craft;
using Server.Network;

namespace Server.Items
{
    #region Reward Clothing
    public class ZooMemberBonnet : Bonnet
    {
        public override int LabelNumber => 1073221; // Britannia Royal Zoo Member

        [Constructable]
        public ZooMemberBonnet()
            : this(0)
        {
        }

        [Constructable]
        public ZooMemberBonnet(int hue)
            : base(hue)
        {
        }

        public ZooMemberBonnet(Serial serial)
            : base(serial)
        {
        }

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

    public class ZooMemberFloppyHat : FloppyHat
    {
        public override int LabelNumber => 1073221; // Britannia Royal Zoo Member

        [Constructable]
        public ZooMemberFloppyHat()
            : this(0)
        {
        }

        [Constructable]
        public ZooMemberFloppyHat(int hue)
            : base(hue)
        {
        }

        public ZooMemberFloppyHat(Serial serial)
            : base(serial)
        {
        }

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

    public class LibraryFriendFeatheredHat : FeatheredHat
    {
        public override int LabelNumber => 1073347; // Friends of the Library Feathered Hat

        [Constructable]
        public LibraryFriendFeatheredHat()
            : this(0)
        {
        }

        [Constructable]
        public LibraryFriendFeatheredHat(int hue)
            : base(hue)
        {
        }

        public LibraryFriendFeatheredHat(Serial serial)
            : base(serial)
        {
        }

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

    public class JesterHatOfChuckles : JesterHat
    {
        public override int LabelNumber => 1073256;// Jester Hat of Chuckles - Museum of Vesper Replica

        public override int BasePhysicalResistance => 12;
        public override int BaseFireResistance => 12;
        public override int BaseColdResistance => 12;
        public override int BasePoisonResistance => 12;
        public override int BaseEnergyResistance => 12;

        public override int InitMinHits => 100;
        public override int InitMaxHits => 100;

        [Constructable]
        public JesterHatOfChuckles()
            : this(0)
        {
        }

        [Constructable]
        public JesterHatOfChuckles(int hue)
            : base(hue)
        {
            Attributes.Luck = 150;
        }

        public JesterHatOfChuckles(Serial serial)
            : base(serial)
        {
        }

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

    public class NystulsWizardsHat : WizardsHat
    {
        public override int LabelNumber => 1073255;// Nystul's Wizard's Hat - Museum of Vesper Replica

        public override int BasePhysicalResistance => 10;
        public override int BaseFireResistance => 10;
        public override int BaseColdResistance => 10;
        public override int BasePoisonResistance => 10;
        public override int BaseEnergyResistance => 25;

        public override int InitMinHits => 100;
        public override int InitMaxHits => 100;

        [Constructable]
        public NystulsWizardsHat()
            : this(0)
        {
        }

        [Constructable]
        public NystulsWizardsHat(int hue)
            : base(hue)
        {
            Attributes.LowerManaCost = 15;
        }

        public NystulsWizardsHat(Serial serial)
            : base(serial)
        {
        }

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

    public class GypsyHeaddress : SkullCap
    {
        public override int LabelNumber => 1073254;// Gypsy Headdress - Museum of Vesper Replica

        public override int BasePhysicalResistance => 15;
        public override int BaseFireResistance => 20;
        public override int BaseColdResistance => 20;
        public override int BasePoisonResistance => 15;
        public override int BaseEnergyResistance => 15;

        public override int InitMinHits => 100;
        public override int InitMaxHits => 100;

        [Constructable]
        public GypsyHeaddress()
            : this(0)
        {
        }

        [Constructable]
        public GypsyHeaddress(int hue)
            : base(hue)
        {
        }

        public GypsyHeaddress(Serial serial)
            : base(serial)
        {
        }

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
    #endregion

    [Flipable(0x2798, 0x27E3)]
    public class Kasa : BaseHat
    {
        public override int BasePhysicalResistance => 0;
        public override int BaseFireResistance => 5;
        public override int BaseColdResistance => 9;
        public override int BasePoisonResistance => 5;
        public override int BaseEnergyResistance => 5;

        public override int InitMinHits => 20;
        public override int InitMaxHits => 30;

        [Constructable]
        public Kasa()
            : this(0)
        {
        }

        [Constructable]
        public Kasa(int hue)
            : base(0x2798, hue)
        {
        }

        public Kasa(Serial serial)
            : base(serial)
        {
        }

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

    [Flipable(0x278F, 0x27DA)]
    public class ClothNinjaHood : BaseHat
    {
        public override int BasePhysicalResistance => 3;
        public override int BaseFireResistance => 3;
        public override int BaseColdResistance => 6;
        public override int BasePoisonResistance => 9;
        public override int BaseEnergyResistance => 9;

        public override int InitMinHits => 20;
        public override int InitMaxHits => 30;

        [Constructable]
        public ClothNinjaHood()
            : this(0)
        {
        }

        [Constructable]
        public ClothNinjaHood(int hue)
            : base(0x278F, hue)
        {
        }

        public ClothNinjaHood(Serial serial)
            : base(serial)
        {
        }

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

    [Flipable(0x2306, 0x2305)]
    public class FlowerGarland : BaseHat
    {
        public override int BasePhysicalResistance => 3;
        public override int BaseFireResistance => 3;
        public override int BaseColdResistance => 6;
        public override int BasePoisonResistance => 9;
        public override int BaseEnergyResistance => 9;

        public override int InitMinHits => 20;
        public override int InitMaxHits => 30;

        [Constructable]
        public FlowerGarland()
            : this(0)
        {
        }

        [Constructable]
        public FlowerGarland(int hue)
            : base(0x2306, hue)
        {

        }

        public FlowerGarland(Serial serial)
            : base(serial)
        {
        }

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

    public class ChefsToque : BaseHat
    {
        public override int LabelNumber => 1109618;  // Chef's Toque

        public override int BasePhysicalResistance => 0;
        public override int BaseFireResistance => 5;
        public override int BaseColdResistance => 9;
        public override int BasePoisonResistance => 5;
        public override int BaseEnergyResistance => 5;

        public override int InitMinHits => 20;
        public override int InitMaxHits => 30;

        [Constructable]
        public ChefsToque()
            : this(0)
        {
        }

        [Constructable]
        public ChefsToque(int hue)
            : base(0x781A, hue)
        {
        }

        public ChefsToque(Serial serial)
            : base(serial)
        {
        }

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
