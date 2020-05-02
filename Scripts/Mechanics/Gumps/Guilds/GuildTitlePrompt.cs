using System;
using Server.Guilds;
using Server.Prompts;

namespace Server.Gumps
{
    public class GuildTitlePrompt : Prompt
    {
        public override int MessageCliloc => 1011128;
        private readonly Mobile m_Leader;
        private readonly Mobile m_Target;
        private readonly Guild m_Guild;
        public GuildTitlePrompt(Mobile leader, Mobile target, Guild g)
        {
            m_Leader = leader;
            m_Target = target;
            m_Guild = g;
        }

        public override void OnCancel(Mobile from)
        {
            if (GuildGump.BadLeader(m_Leader, m_Guild))
                return;
            else if (m_Target.Deleted || !m_Guild.IsMember(m_Target))
                return;

            GuildGump.EnsureClosed(m_Leader);
            m_Leader.SendGump(new GuildmasterGump(m_Leader, m_Guild));
        }

        public override void OnResponse(Mobile from, string text)
        {
            if (GuildGump.BadLeader(m_Leader, m_Guild))
                return;
            else if (m_Target.Deleted || !m_Guild.IsMember(m_Target))
                return;

            text = text.Trim();

            if (text.Length > 20)
                text = text.Substring(0, 20);

            if (text.Length > 0)
                m_Target.GuildTitle = text;

            GuildGump.EnsureClosed(m_Leader);
            m_Leader.SendGump(new GuildmasterGump(m_Leader, m_Guild));
        }
    }
}