﻿using System;
using Emignatik.NxFileViewer.Utils;
using LibHac.Common;
using LibHac.Loader;
using LibHac.Tools.Fs;

namespace Emignatik.NxFileViewer.Models.TreeItems.Impl;

public class MainItem : DirectoryEntryItem
{

    public MainItem(NsoHeader nsoHeader, SectionItem parentItem, DirectoryEntryEx directoryEntry)
        : base(parentItem, directoryEntry)
    {
        ParentItem = parentItem ?? throw new ArgumentNullException(nameof(parentItem));
        NsoHeader = nsoHeader;
    }

    public override SectionItem ParentItem { get; }

    public NsoHeader NsoHeader { get; }

    public override string LibHacUnderlyingTypeName => "Nso";

    public string ModuleId => NsoHeader.ModuleId.Items.ToStrId();

}