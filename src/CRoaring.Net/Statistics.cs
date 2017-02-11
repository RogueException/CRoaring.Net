﻿using System.Runtime.InteropServices;

namespace CRoaring.Net
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Statistics
    {
        public uint ContainerCount;
        public uint ArrayContainerCount;
        public uint RunContainerCount;
        public uint BitsetContainerCount;

        public uint ArrayContainerValues;
        public uint RunContainerValues;
        public uint BitsetContainerValues;

        public uint ArrayContainerBytes;
        public uint RunContainerBytes;
        public uint BitsetContainerBytes;

        public uint MaxValue;
        public uint MinValue;

        public ulong ValueSum;
        public ulong Cardinality;
    }
}
