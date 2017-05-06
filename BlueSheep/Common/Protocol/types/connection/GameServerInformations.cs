﻿namespace BlueSheep.Common.Protocol.Types.Connection
{
    public class GameServerInformations 
    {
        public new const int ID = 25;
        public virtual int TypeID { get { return ID; } }

        public ushort ObjectID { get; set; }
        public byte ServerType { get; set; }
        public byte Status { get; set; }
        public byte Completion { get; set; }
        public bool IsSelectable { get; set; }
        public byte CharactersCount { get; set; }
        public byte CharactersSlots { get; set; }
        public double Date { get; set; }

        public GameServerInformations() { }

        public GameServerInformations(ushort objectId, byte serverType, byte status, byte completion, bool isSelectable, byte charactersCount, byte charactersSlots, double date)
        {
            ObjectID = objectId;
            ServerType = serverType;
            Status = status;
            Completion = completion;
            IsSelectable = isSelectable;
            CharactersCount = charactersCount;
            CharactersSlots = charactersSlots;
            Date = date;
        }

        public void Serialize(IDataWriter writer)
        {
            writer.WriteVarShort(ObjectID);
            writer.WriteByte(ServerType);
            writer.WriteByte(Status);
            writer.WriteByte(Completion);
            writer.WriteBoolean(IsSelectable);
            writer.WriteByte(CharactersCount);
            writer.WriteByte(CharactersSlots);
            writer.WriteDouble(Date);
        }

        public void Deserialize(IDataReader reader)
        {
            ObjectID = reader.ReadVarUhShort();
            ServerType = reader.ReadByte();
            Status = reader.ReadByte();
            Completion = reader.ReadByte();
            IsSelectable = reader.ReadBoolean();
            CharactersCount = reader.ReadByte();
            CharactersSlots = reader.ReadByte();
            Date = reader.ReadDouble();
        }

    }
}
