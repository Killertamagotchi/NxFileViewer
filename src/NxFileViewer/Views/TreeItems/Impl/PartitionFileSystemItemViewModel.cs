﻿using System;
using Emignatik.NxFileViewer.Models.TreeItems.Impl;
using Emignatik.NxFileViewer.Views.ObjectPropertyViewer;

namespace Emignatik.NxFileViewer.Views.TreeItems.Impl;

public abstract class PartitionFileSystemItemViewModel : ItemViewModel
{
    private readonly PartitionFileSystemItemBase _partitionFileSystemItem;

    protected PartitionFileSystemItemViewModel(PartitionFileSystemItemBase partitionFileSystemItem, IServiceProvider serviceProvider)
        : base(partitionFileSystemItem, serviceProvider)
    {
        _partitionFileSystemItem = partitionFileSystemItem;
    }

    [PropertyView]
    public string PartitionType => _partitionFileSystemItem.PartitionType;

    [PropertyView]
    public int NumFiles => _partitionFileSystemItem.NbEntries;
}