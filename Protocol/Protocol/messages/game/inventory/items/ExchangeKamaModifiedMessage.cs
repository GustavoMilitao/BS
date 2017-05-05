









// Generated on 12/11/2014 19:01:53
using System;
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeKamaModifiedMessage : ExchangeObjectMessage
    {
        public new const uint ID =5521;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int quantity;
        
        public ExchangeKamaModifiedMessage()
        {
        }
        
        public ExchangeKamaModifiedMessage(bool remote, int quantity)
         : base(remote)
        {
            this.quantity = quantity;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarInt(quantity);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            base.Deserialize(reader);
            quantity = reader.ReadVarInt();
            if (quantity < 0)
                throw new Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
        }
        
    }
    
}