﻿using BlueSheep.Common.IO;
using System;

namespace BlueSheep.Data.D2p.Elements
{
    public class GraphicalElement : BasicElement
    {
        // Methods
        internal override void Init(BigEndianReader Reader, int MapVersion)
        {
            ElementId = Convert.ToInt32(Reader.ReadUInt());
            Hue = new ColorMultiplicator(Reader.ReadSByte(), Reader.ReadSByte(), Reader.ReadSByte());
            Shadow = new ColorMultiplicator(Reader.ReadSByte(), Reader.ReadSByte(), Reader.ReadSByte());
            if ((MapVersion <= 4))
            {
                OffsetX = Reader.ReadSByte();
                OffsetY = Reader.ReadSByte();
                PixelOffsetX = (OffsetX * 43);
                PixelOffsetY = (OffsetY * 21.5);
            }
            else
            {
                PixelOffsetX = Reader.ReadShort();
                PixelOffsetY = Reader.ReadShort();
                OffsetX = (PixelOffsetX / 43);
                OffsetY = (PixelOffsetY / 21.5);
            }
            Altitude = Reader.ReadSByte();
            Identifier = Convert.ToInt32(Reader.ReadUInt());
        }


        // Fields
        public int Altitude;
        public int ElementId;
        public ColorMultiplicator FinalTeint;
        public ColorMultiplicator Hue;
        public int Identifier;
        public double OffsetX;
        public double OffsetY;
        public double PixelOffsetX;
        public double PixelOffsetY;
        public ColorMultiplicator Shadow;
    }
}
