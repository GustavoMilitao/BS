


















// Generated on 12/11/2014 19:02:04
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class FightLoot
{

public new const int ID = 41;
public virtual int TypeId
{
    get { return ID; }
}

public int[] objects;
        public int kamas;
        

public FightLoot()
{
}

public FightLoot(int[] objects, int kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 writer.WriteVarShort((short)entry);
            }
            writer.WriteVarInt(kamas);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objects = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = reader.ReadVarUhShort();
            }
            kamas = reader.ReadVarInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}