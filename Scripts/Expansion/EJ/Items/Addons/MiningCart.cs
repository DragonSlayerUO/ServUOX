using Server.Engines.VeteranRewards;
using Server.Multis;
using Server.Network;
using System;

namespace Server.Items
{
    public enum MiningCartType
    {
        OreSouth = 100,
        OreEast = 101,
        GemSouth = 102,
        GemEast = 103
    }

    public class MiningCart : BaseAddon, IRewardItem
    {
        public override bool ForceShowProperties => true;

        public override BaseAddonDeed Deed
        {
            get
            {
                MiningCartDeed deed = new MiningCartDeed
                {
                    IsRewardItem = IsRewardItem,
                    Gems = m_Gems,
                    Ore = m_Ore
                };

                return deed;
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem { get; set; }

        [CommandProperty(AccessLevel.GameMaster)]
        public MiningCartType CartType { get; private set; }

        private int m_Gems;

        [CommandProperty(AccessLevel.GameMaster)]
        public int Gems
        {
            get => m_Gems;
            set
            {
                m_Gems = value;
                UpdateProperties();
            }
        }

        private int m_Ore;

        [CommandProperty(AccessLevel.GameMaster)]
        public int Ore
        {
            get => m_Ore;
            set
            {
                m_Ore = value;
                UpdateProperties();
            }
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public DateTime NextResourceCount { get; set; }

        [Constructible]
        public MiningCart(MiningCartType type)
            : base()
        {
            CartType = type;

            switch (type)
            {
                case MiningCartType.OreSouth:
                    AddComponent(new InternalAddonComponent(0x1A83, 1026786), 0, 0, 0);
                    AddComponent(new InternalAddonComponent(0x1A82, 1026786), 0, 1, 0);
                    AddComponent(new InternalAddonComponent(0x1A86, 1026786), 0, -1, 0);
                    break;
                case MiningCartType.OreEast:
                    AddComponent(new InternalAddonComponent(0x1A88, 1026786), 0, 0, 0);
                    AddComponent(new InternalAddonComponent(0x1A87, 1026786), 1, 0, 0);
                    AddComponent(new InternalAddonComponent(0x1A8B, 1026786), -1, 0, 0);
                    break;
                case MiningCartType.GemSouth:
                    AddComponent(new InternalAddonComponent(0x1A83, 1080388), 0, 0, 0);
                    AddComponent(new InternalAddonComponent(0x1A82, 1080388), 0, 1, 0);
                    AddComponent(new InternalAddonComponent(0x1A86, 1080388), 0, -1, 0);

                    AddComponent(new AddonComponent(0xF2C), 0, 0, 6);
                    AddComponent(new AddonComponent(0xF1D), 0, 0, 5);
                    AddComponent(new AddonComponent(0xF2B), 0, 0, 2);
                    AddComponent(new AddonComponent(0xF21), 0, 0, 1);
                    AddComponent(new AddonComponent(0xF22), 0, 0, 4);
                    AddComponent(new AddonComponent(0xF2F), 0, 0, 5);
                    AddComponent(new AddonComponent(0xF26), 0, 0, 6);
                    AddComponent(new AddonComponent(0xF27), 0, 0, 3);
                    AddComponent(new AddonComponent(0xF29), 0, 0, 0);
                    break;
                case MiningCartType.GemEast:
                    AddComponent(new InternalAddonComponent(0x1A88, 1080388), 0, 0, 0);
                    AddComponent(new InternalAddonComponent(0x1A87, 1080388), 1, 0, 0);
                    AddComponent(new InternalAddonComponent(0x1A8B, 1080388), -1, 0, 0);

                    AddComponent(new AddonComponent(0xF2E), 0, 0, 6);
                    AddComponent(new AddonComponent(0xF12), 0, 0, 3);
                    AddComponent(new AddonComponent(0xF29), 0, 0, 1);
                    AddComponent(new AddonComponent(0xF24), 0, 0, 5);
                    AddComponent(new AddonComponent(0xF21), 0, 0, 1);
                    AddComponent(new AddonComponent(0xF2B), 0, 0, 3);
                    AddComponent(new AddonComponent(0xF2F), 0, 0, 4);
                    AddComponent(new AddonComponent(0xF23), 0, 0, 3);
                    AddComponent(new AddonComponent(0xF27), 0, 0, 3);
                    break;
            }

            NextResourceCount = DateTime.UtcNow + TimeSpan.FromDays(1);
        }

        public MiningCart(Serial serial)
            : base(serial)
        {
        }

        private void TryGiveResourceCount()
        {
            if (NextResourceCount < DateTime.UtcNow)
            {
                switch (CartType)
                {
                    case MiningCartType.OreSouth:
                    case MiningCartType.OreEast:
                        m_Ore = Math.Min(100, m_Ore + 10);
                        break;
                    case MiningCartType.GemSouth:
                    case MiningCartType.GemEast:
                        m_Gems = Math.Min(50, m_Gems + 5);
                        break;
                }

                NextResourceCount = DateTime.UtcNow + TimeSpan.FromDays(1);
            }
        }

        public override void OnComponentUsed(AddonComponent c, Mobile from)
        {
            BaseHouse house = BaseHouse.FindHouseAt(this);

            /*
            * Unique problems have unique solutions.  OSI does not have a problem with 1000s of mining carts
            * due to the fact that they have only a miniscule fraction of the number of 10 year vets that a
            * typical ServUOX shard will have (ServUOX's scaled down account aging system makes this a unique problem),
            * and the "freeness" of free accounts. We also dont have mitigating factors like inactive (unpaid)
            * accounts not gaining veteran time.
            *
            * The lack of high end vets and vet rewards on OSI has made testing the *exact* ranging/stacking
            * behavior of these things all but impossible, so either way its just an estimation.
            *
            * If youd like your shard's carts/stumps to work the way they did before, simply replace the check
            * below with this line of code:
            *
            * if (!from.InRange(GetWorldLocation(), 2)
            *
            * However, I am sure these checks are more accurate to OSI than the former version was.
            *
            */

            if (!from.InRange(GetWorldLocation(), 2) || !from.InLOS(this) || !((from.Z - Z) > -3 && (from.Z - Z) < 3))
            {
                from.LocalOverheadMessage(Network.MessageType.Regular, 0x3B2, 1019045); // I can't reach that.
            }
            else if (house != null && house.HasSecureAccess(from, SecureLevel.Friends))
            {
                switch (CartType)
                {
                    case MiningCartType.OreSouth:
                    case MiningCartType.OreEast:
                        if (m_Ore > 0)
                        {
                            Item ingots = null;

                            switch (Utility.Random(9))
                            {
                                case 0:
                                    ingots = new IronIngot();
                                    break;
                                case 1:
                                    ingots = new DullCopperIngot();
                                    break;
                                case 2:
                                    ingots = new ShadowIronIngot();
                                    break;
                                case 3:
                                    ingots = new CopperIngot();
                                    break;
                                case 4:
                                    ingots = new BronzeIngot();
                                    break;
                                case 5:
                                    ingots = new GoldIngot();
                                    break;
                                case 6:
                                    ingots = new AgapiteIngot();
                                    break;
                                case 7:
                                    ingots = new VeriteIngot();
                                    break;
                                case 8:
                                    ingots = new ValoriteIngot();
                                    break;
                            }

                            if (ingots != null)
                            {
                                int amount = Math.Min(10, m_Ore);
                                ingots.Amount = amount;

                                if (!from.PlaceInBackpack(ingots))
                                {
                                    ingots.Delete();
                                    from.SendLocalizedMessage(1078837); // Your backpack is full! Please make room and try again.
                                }
                                else
                                {
                                    PublicOverheadMessage(MessageType.Regular, 0, 1094724, amount.ToString()); // Ore: ~1_COUNT~
                                    m_Ore -= amount;
                                }
                            }
                        }
                        else
                        {
                            from.SendLocalizedMessage(1094725); // There are no more resources available at this time.
                        }

                        break;
                    case MiningCartType.GemSouth:
                    case MiningCartType.GemEast:
                        if (m_Gems > 0)
                        {
                            Item gems = null;

                            switch (Utility.Random(15))
                            {
                                case 0:
                                    gems = new Amber();
                                    break;
                                case 1:
                                    gems = new Amethyst();
                                    break;
                                case 2:
                                    gems = new Citrine();
                                    break;
                                case 3:
                                    gems = new Diamond();
                                    break;
                                case 4:
                                    gems = new Emerald();
                                    break;
                                case 5:
                                    gems = new Ruby();
                                    break;
                                case 6:
                                    gems = new Sapphire();
                                    break;
                                case 7:
                                    gems = new StarSapphire();
                                    break;
                                case 8:
                                    gems = new Tourmaline();
                                    break;
                                // Mondain's Legacy gems
                                case 9:
                                    gems = new PerfectEmerald();
                                    break;
                                case 10:
                                    gems = new DarkSapphire();
                                    break;
                                case 11:
                                    gems = new Turquoise();
                                    break;
                                case 12:
                                    gems = new EcruCitrine();
                                    break;
                                case 13:
                                    gems = new FireRuby();
                                    break;
                                case 14:
                                    gems = new BlueDiamond();
                                    break;
                            }

                            if (gems != null)
                            {
                                int amount = Math.Min(5, m_Gems);
                                gems.Amount = amount;

                                if (!from.PlaceInBackpack(gems))
                                {
                                    gems.Delete();
                                    from.SendLocalizedMessage(1078837); // Your backpack is full! Please make room and try again.
                                }
                                else
                                {
                                    PublicOverheadMessage(MessageType.Regular, 0, 1094723, amount.ToString()); // Gems: ~1_COUNT~
                                    m_Gems -= amount;
                                }
                            }
                        }
                        else
                        {
                            from.SendLocalizedMessage(1094725); // There are no more resources available at this time.
                        }

                        break;
                }
            }
            else
            {
                from.SendLocalizedMessage(1061637); // You are not allowed to access 
            }
        }

        private class InternalAddonComponent : LocalizedAddonComponent
        {
            public InternalAddonComponent(int id, int localization)
                : base(id, localization)
            {
            }

            public override void GetProperties(ObjectPropertyList list)
            {
                base.GetProperties(list);

                if (Addon is MiningCart)
                {
                    switch (((MiningCart)Addon).CartType)
                    {
                        case MiningCartType.OreSouth:
                        case MiningCartType.OreEast: list.Add(1094724, ((MiningCart)Addon).Ore.ToString()); break; // Ore: ~1_COUNT~
                        case MiningCartType.GemSouth:
                        case MiningCartType.GemEast: list.Add(1094723, ((MiningCart)Addon).Gems.ToString()); break; // Gems: ~1_COUNT~
                    }
                }
            }

            public InternalAddonComponent(Serial serial)
                : base(serial)
            {
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
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.WriteEncodedInt(1);

            TryGiveResourceCount();

            #region version 1
            writer.Write((int)CartType);
            #endregion

            writer.Write(IsRewardItem);
            writer.Write(m_Gems);
            writer.Write(m_Ore);
            writer.Write(NextResourceCount);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadEncodedInt();

            switch (version)
            {
                case 1:
                    CartType = (MiningCartType)reader.ReadInt();
                    goto case 0;
                case 0:
                    IsRewardItem = reader.ReadBool();
                    m_Gems = reader.ReadInt();
                    m_Ore = reader.ReadInt();

                    NextResourceCount = reader.ReadDateTime();
                    break;
            }
        }
    }
}
