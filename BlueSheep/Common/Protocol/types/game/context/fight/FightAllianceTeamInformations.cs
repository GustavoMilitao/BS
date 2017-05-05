


















// Generated on 12/11/2014 19:02:04
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

    public class FightAllianceTeamInformations : FightTeamInformations
    {

        public new const int ID = 439;
        public override int TypeId
        {
            get { return ID; }
        }

        public sbyte relation;


        public FightAllianceTeamInformations()
        {
        }

        public FightAllianceTeamInformations(byte teamId, int leaderId, byte teamSide, byte teamTypeId, byte nbWaves, Types.FightTeamMemberInformations[] teamMembers, sbyte relation)
                 : base(teamId, leaderId, teamSide, teamTypeId, nbWaves, teamMembers)
        {
            this.relation = relation;
        }


        public override void Serialize(BigEndianWriter writer)
        {

            base.Serialize(writer);
            writer.WriteSByte(relation);


        }

        public override void Deserialize(BigEndianReader reader)
        {

            base.Deserialize(reader);
            relation = reader.ReadSByte();
            if (relation < 0)
                throw new Exception("Forbidden value on relation = " + relation + ", it doesn't respect the following condition : relation < 0");


        }


    }


}