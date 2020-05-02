using System;

namespace Server.Ethics
{
    public class EthicDefinition
    {
        private readonly int m_PrimaryHue;
        private readonly TextDefinition m_Title;
        private readonly TextDefinition m_Adjunct;
        private readonly TextDefinition m_JoinPhrase;
        private readonly Power[] m_Powers;
        public EthicDefinition(int primaryHue, TextDefinition title, TextDefinition adjunct, TextDefinition joinPhrase, Power[] powers)
        {
            this.m_PrimaryHue = primaryHue;

            this.m_Title = title;
            this.m_Adjunct = adjunct;

            this.m_JoinPhrase = joinPhrase;

            this.m_Powers = powers;
        }

        public int PrimaryHue => this.m_PrimaryHue;
        public TextDefinition Title => this.m_Title;
        public TextDefinition Adjunct => this.m_Adjunct;
        public TextDefinition JoinPhrase => this.m_JoinPhrase;
        public Power[] Powers => this.m_Powers;
    }
}