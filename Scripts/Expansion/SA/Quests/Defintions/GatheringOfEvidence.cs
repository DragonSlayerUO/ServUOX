using System;
using Server.Items;

namespace Server.Engines.Quests
{
    public class GatheringOfEvidence : BaseQuest
    {
        public override bool DoneOnce => true;

        public GatheringOfEvidence() : base()
        {
            AddObjective(new ObtainObjective(typeof(VoidCrystalOfCorruptedArcaneEssence), "Void Crystal of Corrupted Arcane Essence", 1));
            AddObjective(new ObtainObjective(typeof(VoidCrystalOfCorruptedSpiritualEssence), "Void Crystal of Corrupted Spiritual Essence", 1));
            AddObjective(new ObtainObjective(typeof(VoidCrystalOfCorruptedMysticalEssence), "Void Crystal of Corrupted Mystical Essence", 1));

            AddReward(new BaseReward(typeof(ResonantShieldOfVengeance), "Resonant Shield of Vengeance"));
            AddReward(new BaseReward(typeof(WindOfCorruption), "Wind of Corruption"));
        }

        public override object Title => 1150316; // Gathering of Evidence (Gargoyle Rewards)

        /*There seems to be unrest spreading among the refugees surrounding the Royal city. There are 
         * rumors of gargoyles willingly leaving their encampments and disappearing into the abyss. 
         * Through our own investigations, we have learned that there are militant gargoyle camps in 
         * the abyss where their magically gifted members are tapping into a new source of magic. We 
         * suspect they are tapping the void energies and require you to obtain proof so that we can 
         * prepare a plan of action to deal with any threat they may pose. Bring back all of the following;
         * Void Crystal of Corrupted Arcane Essence, Void Crystal of Corrupted Spiritual Essence, and a 
         * Void Crystal of Corrupted Mystical Essence.*/
        public override object Description => 1150317;

        public override object Refuse => "That's a shame.";

        //Have you retrieved the essences? We cannot prepare our strategy without solid evidence.
        public override object Uncomplete => 1150319;

        /*Well Done! This is just what we needed. We can ill afford these separatist encampments 
         * upsetting the delicate balance with the void consuming our world.*/
        public override object Complete => 1150320;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }

    public class GatheringProof : BaseQuest
    {
        public override bool DoneOnce => true;

        public GatheringProof()
            : base()
        {
            AddObjective(new ObtainObjective(typeof(VoidCrystalOfCorruptedArcaneEssence), "Void Crystal of Corrupted Arcane Essence", 1));
            AddObjective(new ObtainObjective(typeof(VoidCrystalOfCorruptedSpiritualEssence), "Void Crystal of Corrupted Spiritual Essence", 1));
            AddObjective(new ObtainObjective(typeof(VoidCrystalOfCorruptedMysticalEssence), "Void Crystal of Corrupted Mystical Essence", 1));

            AddReward(new BaseReward(typeof(ResonantShieldOfVengeanceHuman), "Resonant Shield of Vengeance"));
            AddReward(new BaseReward(typeof(WindOfCorruptionHuman), "Wind of Corruption"));
        }

        public override object Title => 1150384; // Gathering Proof (Human Rewards)

        /*There seems to be unrest spreading among the refugees surrounding the Royal city. There are 
         * rumors of gargoyles willingly leaving their encampments and disappearing into the abyss. 
         * Through our own investigations, we have learned that there are militant gargoyle camps in 
         * the abyss where their magically gifted members are tapping into a new source of magic. We 
         * suspect they are tapping the void energies and require you to obtain proof so that we can 
         * prepare a plan of action to deal with any threat they may pose. Bring back all of the following;
         * Void Crystal of Corrupted Arcane Essence, Void Crystal of Corrupted Spiritual Essence, and a 
         * Void Crystal of Corrupted Mystical Essence.*/
        public override object Description => 1150317;

        public override object Refuse => "That's a shame.";

        //Have you retrieved the essences? We cannot prepare our strategy without solid evidence.
        public override object Uncomplete => 1150319;

        /*Well Done! This is just what we needed. We can ill afford these separatist encampments 
         * upsetting the delicate balance with the void consuming our world.*/
        public override object Complete => 1150320;
        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}
