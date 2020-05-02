﻿using System;

namespace Server.Items
{
    public enum DawnsMusicRarity
    {
        Common,
        Uncommon,
        Rare,
    }

    public class DawnsMusicInfo
    {
        private readonly int m_Name;
        private readonly DawnsMusicRarity m_Rarity;
        public DawnsMusicInfo(int name, DawnsMusicRarity rarity)
        {
            this.m_Name = name;
            this.m_Rarity = rarity;
        }

        public int Name => this.m_Name;
        public DawnsMusicRarity Rarity => this.m_Rarity;
    }
}