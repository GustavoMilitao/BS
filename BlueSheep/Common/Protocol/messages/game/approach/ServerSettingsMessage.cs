﻿using BlueSheep.Engine.Types;

namespace BlueSheep.Common.Protocol.Messages.Game.Approach
{
    class ServerSettingsMessage : Message
    {
        public new const int ID = 6340;
        public override int MessageID { get { return ID; } }

        public string Lang;
        public byte Community;
        public byte GameType;
        public ushort ArenaLeaveBanTime;

        public ServerSettingsMessage() { }

        public ServerSettingsMessage(string lang, byte community, byte gameType, ushort arenaLeaveBanTime)
        {
            Lang = lang;
            Community = community;
            GameType = gameType;
            ArenaLeaveBanTime = arenaLeaveBanTime;
        }

        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(Lang);
            writer.WriteByte(Community);
            writer.WriteByte(GameType);
            writer.WriteVarShort(ArenaLeaveBanTime);
        }

        public override void Deserialize(IDataReader reader)
        {
            Lang = reader.ReadUTF();
            Community = reader.ReadByte();
            GameType = reader.ReadByte();
            ArenaLeaveBanTime = reader.ReadVarUhShort();
        }
    }
}
