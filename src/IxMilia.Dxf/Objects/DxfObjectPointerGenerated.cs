// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfObjectPointer class
    /// </summary>
    public partial class DxfObjectPointer : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.ObjectPointer; } }

        public string AseXData { get; set; }

        public DxfObjectPointer()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.AseXData = null;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(1001, (this.AseXData)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1001:
                    this.AseXData = (pair.StringValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
