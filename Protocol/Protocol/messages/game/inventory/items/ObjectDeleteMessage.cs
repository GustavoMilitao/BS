









// Generated on 12/11/2014 19:01:55
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ObjectDeleteMessage : Message
    {
        public new const uint ID =3022;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int objectUID;
        public int quantity;
        
        public ObjectDeleteMessage()
        {
        }
        
        public ObjectDeleteMessage(int objectUID, int quantity)
        {
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteVarInt(objectUID);
            writer.WriteVarInt(quantity);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            objectUID = reader.ReadVarInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
        }
        
    }
    
}