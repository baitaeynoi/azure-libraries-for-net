// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.UpdateTxtRecordSet
{
    using Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update;

    /// <summary>
    /// The entirety of a TXT record set update as a part of parent DNS zone update.
    /// </summary>
    public interface IUpdateTxtRecordSet :
        Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update.IWithTxtRecordTextValue,
        Microsoft.Azure.Management.Dns.Fluent.DnsRecordSet.Update.IUpdate
    {

    }
}