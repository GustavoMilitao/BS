


















// Generated on 12/11/2014 19:02:09
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

public class ObjectItemToSellInHumanVendorShop : Item
{

public new const int ID = 359;
public override int TypeId
{
    get { return ID; }
}

public int objectGID;
        public Types.ObjectEffect[] effects;
        public int objectUID;
        public int quantity;
        public int objectPrice;
        public int publicPrice;
        

public ObjectItemToSellInHumanVendorShop()
{
}

public ObjectItemToSellInHumanVendorShop(int objectGID, Types.ObjectEffect[] effects, int objectUID, int quantity, int objectPrice, int publicPrice)
        {
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
            this.objectPrice = objectPrice;
            this.publicPrice = publicPrice;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteVarShort((short)objectGID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort((short)entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteVarInt(objectUID);
            writer.WriteVarInt(quantity);
            writer.WriteVarInt(objectPrice);
            writer.WriteVarInt(publicPrice);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            objectGID = reader.ReadVarUhShort();
            if (objectGID < 0)
                throw new Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = Types.ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadUShort());
                 effects[i].Deserialize(reader);
            }
            objectUID = reader.ReadVarInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            objectPrice = reader.ReadVarInt();
            if (objectPrice < 0)
                throw new Exception("Forbidden value on objectPrice = " + objectPrice + ", it doesn't respect the following condition : objectPrice < 0");
            publicPrice = reader.ReadVarInt();
            if (publicPrice < 0)
                throw new Exception("Forbidden value on publicPrice = " + publicPrice + ", it doesn't respect the following condition : publicPrice < 0");
            

}


}


}