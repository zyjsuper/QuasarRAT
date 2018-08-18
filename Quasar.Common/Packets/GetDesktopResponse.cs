﻿using ProtoBuf;
using Quasar.Common.Video;

namespace Quasar.Common.Packets
{
    [ProtoContract]
    public class GetDesktopResponse : IPacket
    {
        [ProtoMember(1)]
        public byte[] Image { get; set; }

        [ProtoMember(2)]
        public int Quality { get; set; }

        [ProtoMember(3)]
        public int Monitor { get; set; }

        [ProtoMember(4)]
        public Resolution Resolution { get; set; }
    }
}