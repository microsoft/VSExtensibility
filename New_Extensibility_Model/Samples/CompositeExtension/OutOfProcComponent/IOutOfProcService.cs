﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace OutOfProcComponent;

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.ServiceHub.Framework;

public interface IOutOfProcService
{
    Task DoSomethingAsync(CancellationToken cancellationToken);

    public static class Configuration
    {
        public const string ServiceName = "OutOfProcComponent.OutOfProcService";
        public static readonly Version ServiceVersion = new(1, 0);

        public static readonly ServiceMoniker ServiceMoniker = new(ServiceName, ServiceVersion);

        public static ServiceRpcDescriptor ServiceDescriptor => new ServiceJsonRpcDescriptor(
            ServiceMoniker,
            ServiceJsonRpcDescriptor.Formatters.MessagePack,
            ServiceJsonRpcDescriptor.MessageDelimiters.BigEndianInt32LengthHeader);
    }
}
