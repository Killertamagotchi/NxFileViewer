﻿using System;
using System.Collections.Generic;
using LibHac.Fs;
using LibHac.Fs.Fsa;
using LibHac.Spl;
using LibHac.Tools.Es;
using LibHac.Tools.Fs;

namespace Emignatik.NxFileViewer.Models.TreeItems.Impl;

public class TicketItem : PartitionFileEntryItemBase
{
    private readonly Ticket _ticket;

    public TicketItem(Ticket ticket, DirectoryEntryEx ticketFileEntry, IFile file, PartitionFileSystemItemBase parentItem) : base(ticketFileEntry, file, parentItem)
    {
        _ticket = ticket ?? throw new ArgumentNullException(nameof(ticket));
    }

    public override IEnumerable<IItem> ChildItems { get { yield break; } }

    public override string Format => nameof(Ticket);

    public string Issuer => _ticket.Issuer;

    public ulong DeviceId => _ticket.DeviceId;

    public uint AccountId => _ticket.AccountId;

    public ulong TicketId => _ticket.TicketId;

    public RightsId? RightsId { get; internal set; }

    public AccessKey? AccessKey { get; internal set; }

    public byte CryptoType => _ticket.CryptoType;

    public byte FormatVersion => _ticket.FormatVersion;

    public TitleKeyType TitleKeyType => _ticket.TitleKeyType;

    public LicenseType LicenseType => _ticket.LicenseType;

    public ushort TicketVersion => _ticket.TicketVersion;

    public PropertyFlags PropertyMask => _ticket.PropertyMask;

}