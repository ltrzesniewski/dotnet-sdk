// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using Microsoft.DotNet.Workloads.Workload.Install.InstallRecord;

namespace Microsoft.DotNet.Workloads.Workload.Install
{
    internal interface IWorkloadInstaller : IInstaller
    {
        void InstallWorkload(WorkloadId workloadId, string offlineCache = null);

        void DownloadToOfflineCache(WorkloadId workload, string offlineCache);

        void UninstallWorkload(WorkloadId workloadId);

        IEnumerable<string> ListInstalledWorkloads();
    }
}
