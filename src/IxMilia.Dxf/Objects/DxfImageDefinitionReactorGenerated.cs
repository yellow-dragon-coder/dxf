// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfImageDefinitionReactor class
    /// </summary>
    public partial class DxfImageDefinitionReactor : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.ImageDefinitionReactor; } }

        public int ClassVersion { get; set; }

        public DxfImageDefinitionReactor()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.ClassVersion = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbRasterImageDefReactor"));
            pairs.Add(new DxfCodePair(90, (this.ClassVersion)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 90:
                    this.ClassVersion = (pair.IntegerValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
