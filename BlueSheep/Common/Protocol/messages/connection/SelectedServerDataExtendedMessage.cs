﻿using System.Collections.Generic;

namespace BlueSheep.Common.Protocol.Messages.Connection
{
    using BlueSheep.Engine.Types;

 	 public class SelectedServerDataExtendedMessage : SelectedServerDataMessage
    {
        public new const int ID = 6469;
        public override int MessageID { get { return ID; } }

        public List<ushort> ServerIds;

        public SelectedServerDataExtendedMessage(bool canCreateNewCharacter, ushort serverId, string address, ushort port, List<int> ticket, List<ushort> serverIds)
          : base(canCreateNewCharacter, serverId, address, port, ticket)
        {
            this.ServerIds = serverIds;
        }

        public SelectedServerDataExtendedMessage() { }

        public SelectedServerDataExtendedMessage(List<ushort> serverIds)
        {
            ServerIds = serverIds;
        }

        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteShort((short)ServerIds.Count);
            for (int i = 0; i < ServerIds.Count; i++)
            {
                writer.WriteVarShort(ServerIds[i]);
            }
        }

        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            ushort length = reader.ReadUShort();
            ServerIds = new List<ushort>();
            for (int i = 0; i < length; i++)
            {
                ServerIds.Add(reader.ReadVarUhShort());
            }
        }
    }
}
