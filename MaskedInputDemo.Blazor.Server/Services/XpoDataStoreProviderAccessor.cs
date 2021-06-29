using System;
using DevExpress.ExpressApp.Xpo;

namespace MaskedInputDemo.Blazor.Server.Services {
    public class XpoDataStoreProviderAccessor {
        public IXpoDataStoreProvider DataStoreProvider { get; set; }
    }
}
