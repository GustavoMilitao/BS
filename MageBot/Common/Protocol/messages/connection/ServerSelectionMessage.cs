﻿ 

namespace BlueSheep.Common.Protocol.Messages.Connection
{
    public class ServerSelectionMessage : Message
    {
        public const int ProtocolId = 40;
        public override int MessageID { get { return ProtocolId; } }

        private ushort _serverId;

        public ServerSelectionMessage() { }

        public ServerSelectionMessage(ushort serverId)
        {
            _serverId = serverId;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(_serverId);
        }

        public override void Deserialize(IDataReader reader)
        {
            _serverId = reader.ReadVarUhShort();
        }
    }
}
