using System;
using Spartane.Core.Domain.Documento_Extraviado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Documento_Extraviado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDocumento_ExtraviadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Documento_Extraviado.Documento_ExtraviadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Documento_Extraviado.Documento_Extraviado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
