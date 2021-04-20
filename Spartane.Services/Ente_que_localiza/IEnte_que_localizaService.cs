using System;
using Spartane.Core.Domain.Ente_que_localiza;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Ente_que_localiza
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEnte_que_localizaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Ente_que_localiza.Ente_que_localizaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Ente_que_localiza.Ente_que_localiza> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
