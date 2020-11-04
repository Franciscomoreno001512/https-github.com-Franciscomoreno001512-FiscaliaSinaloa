using System;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Catalogo_de_Estatus_de_Folio
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICatalogo_de_Estatus_de_FolioService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_FolioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Folio.Catalogo_de_Estatus_de_Folio> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
