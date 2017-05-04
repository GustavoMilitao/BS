﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlueSheep.Common.IO;

namespace BlueSheep.Data.D2p.Elements
{
    public class SoundElement : BasicElement
    {
        // Methods
        internal override void Init(BigEndianReader Reader, int MapVersion)
        {
            SoundId = Reader.ReadInt();
            BaseVolume = Reader.ReadShort();
            FullVolumeDistance = Reader.ReadInt();
            NullVolumeDistance = Reader.ReadInt();
            MinDelayBetweenLoops = Reader.ReadShort();
            MaxDelayBetweenLoops = Reader.ReadShort();
        }

        // Fields
        public int BaseVolume;
        public int FullVolumeDistance;
        public int MaxDelayBetweenLoops;
        public int MinDelayBetweenLoops;
        public int NullVolumeDistance;
        public int SoundId;
    }
}
