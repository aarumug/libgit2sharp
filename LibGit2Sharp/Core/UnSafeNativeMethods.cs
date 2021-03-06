﻿using System;
using System.Runtime.InteropServices;
using LibGit2Sharp.Core.Handles;

namespace LibGit2Sharp.Core
{
    internal static unsafe class UnSafeNativeMethods
    {
        private const string libgit2 = NativeDllName.Name;

        [DllImport(libgit2)]
        internal static extern int git_reference_list(out git_strarray array, RepositorySafeHandle repo);

        [DllImport(libgit2)]
        internal static extern int git_remote_list(out git_strarray array, RepositorySafeHandle repo);

        [DllImport(libgit2)]
        internal static extern int git_tag_list(out git_strarray array, RepositorySafeHandle repo);

        [DllImport(libgit2)]
        internal static extern void git_strarray_free(ref git_strarray array);

        [DllImport(libgit2)]
        internal static extern int git_remote_get_fetch_refspecs(out git_strarray array, RemoteSafeHandle remote);

        [DllImport(libgit2)]
        internal static extern int git_remote_get_push_refspecs(out git_strarray array, RemoteSafeHandle remote);

        #region Nested type: git_strarray

        internal struct git_strarray
        {
            public sbyte** strings;
            public UIntPtr size;
        }

        #endregion
    }
}
