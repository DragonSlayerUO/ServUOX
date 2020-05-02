using System;

namespace Server.Factions
{
    public class GuardDefinition
    {
        private readonly Type m_Type;
        private readonly int m_Price;
        private readonly int m_Upkeep;
        private readonly int m_Maximum;
        private readonly int m_ItemID;
        private readonly TextDefinition m_Header;
        private readonly TextDefinition m_Label;
        public GuardDefinition(Type type, int itemID, int price, int upkeep, int maximum, TextDefinition header, TextDefinition label)
        {
            this.m_Type = type;

            this.m_Price = price;
            this.m_Upkeep = upkeep;
            this.m_Maximum = maximum;
            this.m_ItemID = itemID;

            this.m_Header = header;
            this.m_Label = label;
        }

        public Type Type => this.m_Type;
        public int Price => this.m_Price;
        public int Upkeep => this.m_Upkeep;
        public int Maximum => this.m_Maximum;
        public int ItemID => this.m_ItemID;
        public TextDefinition Header => this.m_Header;
        public TextDefinition Label => this.m_Label;
    }
}