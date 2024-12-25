﻿using System;
using Emignatik.NxFileViewer.Models.TreeItems;
using Emignatik.NxFileViewer.Models.TreeItems.Impl;
using LibHac.Common.Keys;

namespace Emignatik.NxFileViewer.FileLoading;

/// <summary>
/// <see cref="IItem"/> tree loader from a Nintendo Switch file
/// </summary>
public interface IFileItemLoader
{
    public event MissingKeyExceptionHandler? MissingKey;

    /// <summary>
    /// Loads an XCI file
    /// </summary>
    /// <param name="xciFilePath"></param>
    /// <returns></returns>
    XciItem LoadXci(string xciFilePath);

    /// <summary>
    /// Loads an NSP file
    /// </summary>
    /// <param name="nspFilePath"></param>
    /// <returns></returns>
    NspItem LoadNsp(string nspFilePath);
}

public delegate void MissingKeyExceptionHandler(object sender, MissingKeyExceptionHandlerArgs args);

public class MissingKeyExceptionHandlerArgs
{

    public MissingKeyExceptionHandlerArgs(MissingKeyException ex, IItem? relatedItem)
    {
        Exception = ex ?? throw new ArgumentNullException(nameof(ex));
        RelatedItem = relatedItem;
    }

    public MissingKeyException Exception { get; }


    public IItem? RelatedItem { get; }
}