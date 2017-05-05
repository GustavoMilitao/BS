


















// Generated on 12/11/2014 19:02:06
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

    public class BasicAllianceInformations : AbstractSocialGroupInfos
    {

        public new const int ID = 419;
        public override int TypeId
        {
            get { return ID; }
        }

        public uint allianceId;
        public string allianceTag;


        public BasicAllianceInformations()
        {
        }

        public BasicAllianceInformations(uint allianceId, string allianceTag)
        {
            this.allianceId = allianceId;
            this.allianceTag = allianceTag;
        }


        public override void Serialize(BigEndianWriter writer)
        {

            base.Serialize(writer);
            writer.WriteVarInt(allianceId);
            writer.WriteUTF(allianceTag);


        }

        public override void Deserialize(BigEndianReader reader)
        {

            base.Deserialize(reader);
            allianceId = reader.ReadVarUhInt();
            if (allianceId < 0)
                throw new Exception("Forbidden value on allianceId = " + allianceId + ", it doesn't respect the following condition : allianceId < 0");
            allianceTag = reader.ReadUTF();


        }


    }


}