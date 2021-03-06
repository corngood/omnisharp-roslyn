﻿using System;
using OmniSharp.Models.FilesChanged;

namespace OmniSharp.FileWatching
{
    // TODO: Flesh out this API more
    public interface IFileSystemWatcher
    {
        void Watch(string path, Action<string, FileChangeType> callback);

        /// <summary>
        /// Called when a file is created, changed, or deleted.
        /// </summary>
        /// <param name="path">The path to the file</param>
        /// <param name="changeType">The type of change. Hosts are not required to pass a change type</param>
        void TriggerChange(string path, FileChangeType changeType);

        void WatchDirectory(string path, Action<string, FileChangeType> callback);
    }
}
