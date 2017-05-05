









// Generated on 12/11/2014 19:01:53
using BlueSheep.Common.IO;

namespace BlueSheep.Common.Protocol.Messages
{
    public class ExchangeStartOkNpcTradeMessage : Message
    {
        public new const uint ID =5785;
        public override uint ProtocolID
        {
            get { return ID; }
        }
        
        public int npcId;
        
        public ExchangeStartOkNpcTradeMessage()
        {
        }
        
        public ExchangeStartOkNpcTradeMessage(int npcId)
        {
            this.npcId = npcId;
        }
        
        public override void Serialize(BigEndianWriter writer)
        {
            writer.WriteInt(npcId);
        }
        
        public override void Deserialize(BigEndianReader reader)
        {
            npcId = reader.ReadInt();
        }
        
    }
    
}