﻿namespace Apollo
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct TdirTreeNode
    {
        public int nodeID;
        public int parentID;
        public int flag;
        [MarshalAs(UnmanagedType.LPStr)]
        public string name;
        public int status;
        public int nodeType;
        public int svrFlag;
        public TdirStaticInfo staticInfo;
        public TdirDynamicInfo dynamicInfo;
        public List<TdirUserRoleInfo> userRoleInfo;
    }
}

