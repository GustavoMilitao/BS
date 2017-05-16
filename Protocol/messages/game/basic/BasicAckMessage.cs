﻿ 
namespace BlueSheep.Protocol.Messages.Game.Basic
{
    public class BasicAckMessage : Message
    {
        protected override int ProtocolId { get; set; } = 6362;
        public override int MessageID { get { return ProtocolId; } }

        public uint Seq;
        public ushort LastProtocolId;

        public BasicAckMessage() { }

        public BasicAckMessage(uint seq, ushort lastProtocolId)
        {
            Seq = seq;
            LastProtocolId = lastProtocolId;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt(Seq);
            writer.WriteVarShort(LastProtocolId);
        }

        public override void Deserialize(IDataReader reader)
        {
            Seq = reader.ReadVarUhInt();
            LastProtocolId = reader.ReadVarUhShort();
        }
    }
}
