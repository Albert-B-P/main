/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. All rights reserved.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Apache License, Version 2.0, please send an email to 
 * ironpy@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

class RssProvider : IWebServiceProvider {
    #region IWebServiceProvider Members

    string IWebServiceProvider.Name {
        get { return "Rss"; }
    }

    bool IWebServiceProvider.MatchUrl(string url) {
        return url.EndsWith(".rss", StringComparison.OrdinalIgnoreCase) ||
               url.IndexOf("/rss.", StringComparison.OrdinalIgnoreCase) >= 0;
    }

    object IWebServiceProvider.LoadWebService(string url) {
        byte[] rssBytes = DynamicWebServiceHelpers.GetBytesForUrl(url);
        return DynamicWebServiceHelpers.LoadXmlFromBytes(rssBytes);
    }

    #endregion
}