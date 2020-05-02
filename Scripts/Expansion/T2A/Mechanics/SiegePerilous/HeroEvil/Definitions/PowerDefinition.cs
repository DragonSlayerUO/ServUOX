using System;

namespace Server.Ethics
{
    public class PowerDefinition
    {
        private readonly int m_Power;
        private readonly TextDefinition m_Name;
        private readonly TextDefinition m_Phrase;
        private readonly TextDefinition m_Description;
        public PowerDefinition(int power, TextDefinition name, TextDefinition phrase, TextDefinition description)
        {
            this.m_Power = power;

            this.m_Name = name;
            this.m_Phrase = phrase;
            this.m_Description = description;
        }

        public int Power => this.m_Power;
        public TextDefinition Name => this.m_Name;
        public TextDefinition Phrase => this.m_Phrase;
        public TextDefinition Description => this.m_Description;
    }
}