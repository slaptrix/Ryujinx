using Ryujinx.Core.Logging;
using Ryujinx.Core.OsHle.Ipc;
using System.Collections.Generic;

namespace Ryujinx.Core.OsHle.Services.Mm
{
    class IRequest : IpcService
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public override IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public IRequest()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                { 4, Initialize },
                { 6, SetAndWait },
                { 7, Get        }
            };
        }

        public long Initialize(ServiceCtx Context)
        {
            Context.Ns.Log.PrintStub(LogClass.ServiceMm, "Stubbed.");

            return 0;
        }

        public long SetAndWait(ServiceCtx Context)
        {
            Context.Ns.Log.PrintStub(LogClass.ServiceMm, "Stubbed.");

            return 0;
        }

        public long Get(ServiceCtx Context)
        {
            Context.ResponseData.Write(0);

            Context.Ns.Log.PrintStub(LogClass.ServiceMm, "Stubbed.");

            return 0;
        }
    }
}