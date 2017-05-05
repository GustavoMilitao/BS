


















// Generated on 12/11/2014 19:02:10
using System;
using System.Collections.Generic;
using System.Linq;
using BlueSheep.Common.IO;


namespace BlueSheep.Common.Protocol.Types
{

    public class TaxCollectorInformations
    {

        public new const int ID = 167;
        public virtual int TypeId
        {
            get { return ID; }
        }

        public int uniqueId;
        public int firtNameId;
        public int lastNameId;
        public Types.AdditionalTaxCollectorInformations additionalInfos;
        public int worldX;
        public int worldY;
        public int subAreaId;
        public sbyte state;
        public Types.EntityLook look;
        public Types.TaxCollectorComplementaryInformations[] complements;


        public TaxCollectorInformations()
        {
        }

        public TaxCollectorInformations(int uniqueId, int firtNameId, int lastNameId, Types.AdditionalTaxCollectorInformations additionalInfos, int worldX, int worldY, int subAreaId, sbyte state, Types.EntityLook look, Types.TaxCollectorComplementaryInformations[] complements)
        {
            this.uniqueId = uniqueId;
            this.firtNameId = firtNameId;
            this.lastNameId = lastNameId;
            this.additionalInfos = additionalInfos;
            this.worldX = worldX;
            this.worldY = worldY;
            this.subAreaId = subAreaId;
            this.state = state;
            this.look = look;
            this.complements = complements;
        }


        public virtual void Serialize(BigEndianWriter writer)
        {

            writer.WriteInt(uniqueId);
            writer.WriteVarShort((short)firtNameId);
            writer.WriteVarShort((short)lastNameId);
            additionalInfos.Serialize(writer);
            writer.WriteShort((short)worldX);
            writer.WriteShort((short)worldY);
            writer.WriteVarShort((short)subAreaId);
            writer.WriteSByte(state);
            look.Serialize(writer);
            writer.WriteUShort((ushort)complements.Length);
            foreach (var entry in complements)
            {
                writer.WriteShort((short)entry.TypeId);
                entry.Serialize(writer);
            }


        }

        public virtual void Deserialize(BigEndianReader reader)
        {

            uniqueId = reader.ReadInt();
            firtNameId = reader.ReadVarUhShort();
            if (firtNameId < 0)
                throw new Exception("Forbidden value on firtNameId = " + firtNameId + ", it doesn't respect the following condition : firtNameId < 0");
            lastNameId = reader.ReadVarUhShort();
            if (lastNameId < 0)
                throw new Exception("Forbidden value on lastNameId = " + lastNameId + ", it doesn't respect the following condition : lastNameId < 0");
            additionalInfos = new Types.AdditionalTaxCollectorInformations();
            additionalInfos.Deserialize(reader);
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            subAreaId = reader.ReadVarUhShort();
            if (subAreaId < 0)
                throw new Exception("Forbidden value on subAreaId = " + subAreaId + ", it doesn't respect the following condition : subAreaId < 0");
            state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            look = new Types.EntityLook();
            look.Deserialize(reader);
            var limit = reader.ReadUShort();
            complements = new Types.TaxCollectorComplementaryInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                complements[i] = Types.ProtocolTypeManager.GetInstance<Types.TaxCollectorComplementaryInformations>(reader.ReadUShort());
                complements[i].Deserialize(reader);
            }


        }


    }


}