


















// Generated on 12/11/2014 19:02:08
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class QuestObjectiveInformations
{

public new const int ID = 385;
public virtual int TypeId
{
    get { return ID; }
}

public int objectiveId;
        public bool objectiveStatus;
        public string[] dialogParams;
        

public QuestObjectiveInformations()
{
}

public QuestObjectiveInformations(int objectiveId, bool objectiveStatus, string[] dialogParams)
        {
            this.objectiveId = objectiveId;
            this.objectiveStatus = objectiveStatus;
            this.dialogParams = dialogParams;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteVarShort((short)objectiveId);
            writer.WriteBoolean(objectiveStatus);
            writer.WriteUShort((ushort)dialogParams.Length);
            foreach (var entry in dialogParams)
            {
                 writer.WriteUTF(entry);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

objectiveId = reader.ReadVarUhShort();
            if (objectiveId < 0)
                throw new Exception("Forbidden value on objectiveId = " + objectiveId + ", it doesn't respect the following condition : objectiveId < 0");
            objectiveStatus = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            dialogParams = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 dialogParams[i] = reader.ReadUTF();
            }
            

}


}


}