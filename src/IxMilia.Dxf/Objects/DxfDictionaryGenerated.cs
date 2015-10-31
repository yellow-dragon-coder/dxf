// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IxMilia.Dxf.Objects
{

    /// <summary>
    /// DxfDictionary class
    /// </summary>
    public partial class DxfDictionary : DxfObject
    {
        public override DxfObjectType ObjectType { get { return DxfObjectType.AcdbDictionary; } }

        public bool IsHardOwner { get; set; }
        public DxfDictionaryDuplicateRecordHandling DuplicateRecordHandling { get; set; }
        private List<string> _entryNames { get; set; }
        private List<uint> _entryHandles { get; set; }

        public DxfDictionary()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.IsHardOwner = false;
            this.DuplicateRecordHandling = DxfDictionaryDuplicateRecordHandling.NotApplicable;
            this._entryNames = new List<string>();
            this._entryHandles = new List<uint>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbDictionary"));
            pairs.Add(new DxfCodePair(280, BoolShort(this.IsHardOwner)));
            pairs.Add(new DxfCodePair(281, (short)(this.DuplicateRecordHandling)));
            foreach (var item in _entries)
            {
                pairs.Add(new DxfCodePair(3, item.Key));
                pairs.Add(new DxfCodePair(350, UIntHandle(item.Value)));
            }

        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 3:
                    this._entryNames.Add((pair.StringValue));
                    break;
                case 280:
                    this.IsHardOwner = BoolShort(pair.ShortValue);
                    break;
                case 281:
                    this.DuplicateRecordHandling = (DxfDictionaryDuplicateRecordHandling)(pair.ShortValue);
                    break;
                case 350:
                    this._entryHandles.Add(UIntHandle(pair.StringValue));
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }

}
