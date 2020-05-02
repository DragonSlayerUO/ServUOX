using System;

namespace Server.Items
{
    public class LeatherDyeTub : DyeTub, Engines.VeteranRewards.IRewardItem
    {
        private bool m_IsRewardItem;
        [Constructable]
        public LeatherDyeTub()
        {
            this.LootType = LootType.Blessed;
        }

        public LeatherDyeTub(Serial serial)
            : base(serial)
        {
        }

        public override bool AllowDyables => false;
        public override bool AllowLeather => true;
        public override int TargetMessage => 1042416;// Select the leather item to dye.
        public override int FailMessage => 1042418;// You can only dye leather with this tub.
        public override int LabelNumber => 1041284;// Leather Dye Tub
        public override CustomHuePicker CustomHuePicker => CustomHuePicker.LeatherDyeTub;
        [CommandProperty(AccessLevel.GameMaster)]
        public bool IsRewardItem
        {
            get
            {
                return this.m_IsRewardItem;
            }
            set
            {
                this.m_IsRewardItem = value;
            }
        }
        public override void OnDoubleClick(Mobile from)
        {
            if (this.m_IsRewardItem && !Engines.VeteranRewards.RewardSystem.CheckIsUsableBy(from, this, null))
                return;

            base.OnDoubleClick(from);
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (Core.ML && this.m_IsRewardItem)
                list.Add(1076218); // 2nd Year Veteran Reward
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(1); // version

            writer.Write(m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch (version)
            {
                case 1:
                    {
                        this.m_IsRewardItem = reader.ReadBool();
                        break;
                    }
            }
        }
    }
}