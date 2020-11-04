using System;
using Spartane.Core.Domain.Documento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Documento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDocumentoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Documento.Documento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Documento.Documento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Documento.Documento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Documento.Documento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Documento.Documento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Documento.Documento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Documento.Documento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Documento.Documento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Documento.DocumentoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Documento.Documento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
