﻿namespace RunPE_Shield.PE.Structures
{
    public struct IMAGE_OVERVIEW
    {
        public uint FileHeaderPointer;
        public uint NumberOfSections;
        public uint AddressOfEntrypoint;
        public uint ImageBase;
        public uint SizeOfImage;
        public uint SizeOfHeaders;
    }
}
