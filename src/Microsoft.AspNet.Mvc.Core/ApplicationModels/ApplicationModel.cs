// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNet.Mvc.ApplicationModels
{
    public class ApplicationModel
    {
        public ApplicationModel()
        {
            Controllers = new List<ControllerModel>();
            Filters = new List<IFilter>();
            Properties = new Dictionary<object, object>();
        }

        public IList<ControllerModel> Controllers { get; private set; }

        public IList<IFilter> Filters { get; private set; }

        /// <summary>
        /// Gets a set of properties associated with all actions.
        /// These properties will be copied to <see cref="ActionDescriptor.Properties"/>.
        /// </summary>
        public IDictionary<object, object> Properties { get; }
    }
}