namespace Server.Items
{
    [Flipable(0xA2CA, 0xA2CB)]
    public class ShoulderParrot : BaseOuterTorso
    {
        private DateTime _NextFly;
        private DateTime _FlyEnd;
        private Timer _Timer;
        private Mobile _LastShoulder;

        private string _MasterName;

        [CommandProperty(AccessLevel.GameMaster)]
        public string MasterName { get => _MasterName; set { _MasterName = value; InvalidateProperties(); } }

        [Constructible]
        public ShoulderParrot()
            : base(0xA2CA)
        {
            LootType = LootType.Blessed;
        }

        public override void AddNameProperty(ObjectPropertyList list)
        {
            if (_MasterName != null)
            {
                list.Add(1158958, $"{_MasterName}{(_MasterName.ToLower().EndsWith("s") || _MasterName.ToLower().EndsWith("z") ? "'" : "'s")}");
            }
            else
            {
                list.Add(1158928); // Shoulder Parrot
            }
        }

        public override void OnDoubleClick(Mobile m)
        {
            if (m.FindItemOnLayer(Layer.OuterTorso) == this)
            {
                if (_NextFly > DateTime.UtcNow)
                {
                    m.SendLocalizedMessage(1158956); // Your parrot is too tired to fly right now.
                }
                else
                {
                    _Timer = Timer.DelayCall(TimeSpan.FromMilliseconds(500), TimeSpan.FromMilliseconds(500), FlyOnTick);
                    _Timer.Start();

                    Movable = false;
                    _LastShoulder = m;
                    MoveToWorld(new Point3D(m.X, m.Y, m.Z + 15), m.Map);
                    ItemID = 0xA2CC;

                    _FlyEnd = DateTime.UtcNow + TimeSpan.FromSeconds(Utility.RandomMinMax(3, 5));
                }
            }
            else
            {
                m.SendLocalizedMessage(1158957); // Your parrot can't fly here.
            }
        }

        private void FlyOnTick()
        {
            if (_FlyEnd < DateTime.UtcNow)
            {
                Movable = true;
                ItemID = 0xA2CA;

                if (_LastShoulder.FindItemOnLayer(Layer.OuterTorso) != null)
                {
                    _LastShoulder.Backpack.DropItem(this);
                }
                else
                {
                    _LastShoulder.AddItem(this);
                }

                _LastShoulder = null;
                _Timer.Stop();
                _NextFly = DateTime.UtcNow + TimeSpan.FromMinutes(2);
            }
        }

        public ShoulderParrot(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);

            writer.Write(_MasterName);
            writer.Write(_LastShoulder);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            reader.ReadInt();

            _MasterName = reader.ReadString();
            Mobile m = reader.ReadMobile();

            if (m != null)
            {
                ItemID = 0xA2CA;

                Timer.DelayCall(() =>
                {
                    if (m.FindItemOnLayer(Layer.OuterTorso) != null)
                    {
                        m.Backpack.DropItem(this);
                    }
                    else
                    {
                        m.AddItem(this);
                    }
                });
            }
        }
    }
}
