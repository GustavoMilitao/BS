


















// Generated on 12/11/2014 19:02:06
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

    public class GameRolePlayActorInformations : GameContextActorInformations
    {

        public new const int ID = 141;
        public override int TypeId
        {
            get { return ID; }
        }



        public GameRolePlayActorInformations()
        {
        }

        public GameRolePlayActorInformations(ulong contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition)
                 : base(contextualId, look, disposition)
        {
        }


        public override void Serialize(BigEndianWriter writer)
        {

            base.Serialize(writer);


        }

        public override void Deserialize(BigEndianReader reader)
        {

            base.Deserialize(reader);


        }


    }


}