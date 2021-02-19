using System;
using Spartane.Core.Domain.Generador_Folio_Documentos_AT;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Generador_Folio_Documentos_AT
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGenerador_Folio_Documentos_ATService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_ATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Generador_Folio_Documentos_AT.Generador_Folio_Documentos_AT> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
