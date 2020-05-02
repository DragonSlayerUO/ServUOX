using System;
using Server.Gumps;
using Server.Network;

namespace Server.Items
{
    public class StoneStatueAddon : BaseAddon
    {
        [Constructable]
        public StoneStatueAddon(bool east)
            : base()
        {
            if (east) // east
            {
                this.AddComponent(new LocalizedAddonComponent(0x139E, 1076284), 0, 0, 0);
                this.AddComponent(new LocalizedAddonComponent(0x139F, 1076284), -1, 0, 0);
                this.AddComponent(new LocalizedAddonComponent(0x13A0, 1076284), 0, -1, 0);
            }
            else // south
            {
                this.AddComponent(new LocalizedAddonComponent(0x129F, 1076284), 0, 0, 0);
                this.AddComponent(new LocalizedAddonComponent(0x12A0, 1076284), 0, -1, 0);
                this.AddComponent(new LocalizedAddonComponent(0x12A1, 1076284), -1, 0, 0);
            }
        }

        public StoneStatueAddon(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddonDeed Deed => new StoneStatueDeed();
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }
    }

    public class StoneStatueDeed : BaseAddonDeed
    {
        private bool m_East;
        [Constructable]
        public StoneStatueDeed()
            : base()
        {
            this.LootType = LootType.Blessed;
        }

        public StoneStatueDeed(Serial serial)
            : base(serial)
        {
        }

        public override BaseAddon Addon => new StoneStatueAddon(this.m_East);
        public override int LabelNumber => 1076284;// Statue
        public override void OnDoubleClick(Mobile from)
        {
            if (this.IsChildOf(from.Backpack))
            {
                from.CloseGump(typeof(InternalGump));
                from.SendGump(new InternalGump(this));
            }
            else
                from.SendLocalizedMessage(1062334); // This item must be in your backpack to be used.
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();
        }

        private void SendTarget(Mobile m)
        {
            base.OnDoubleClick(m);
        }

        private class InternalGump : Gump
        {
            private readonly StoneStatueDeed m_Deed;
            public InternalGump(StoneStatueDeed deed)
                : base(60, 36)
            {
                this.m_Deed = deed;

                this.AddPage(0);

                this.AddBackground(0, 0, 273, 324, 0x13BE);
                this.AddImageTiled(10, 10, 253, 20, 0xA40);
                this.AddImageTiled(10, 40, 253, 244, 0xA40);
                this.AddImageTiled(10, 294, 253, 20, 0xA40);
                this.AddAlphaRegion(10, 10, 253, 304);
                this.AddButton(10, 294, 0xFB1, 0xFB2, 0, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(45, 296, 450, 20, 1060051, 0x7FFF, false, false); // CANCEL
                this.AddHtmlLocalized(14, 12, 273, 20, 1076579, 0x7FFF, false, false); // Please select your statue position

                this.AddPage(1);

                this.AddButton(19, 49, 0x845, 0x846, 1, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(44, 47, 213, 20, 1075386, 0x7FFF, false, false); // South
                this.AddButton(19, 73, 0x845, 0x846, 2, GumpButtonType.Reply, 0);
                this.AddHtmlLocalized(44, 71, 213, 20, 1075387, 0x7FFF, false, false); // East
            }

            public override void OnResponse(NetState sender, RelayInfo info)
            {
                if (this.m_Deed == null || this.m_Deed.Deleted || info.ButtonID == 0)
                    return;

                this.m_Deed.m_East = (info.ButtonID != 1);
                this.m_Deed.SendTarget(sender.Mobile);
            }
        }
    }
}