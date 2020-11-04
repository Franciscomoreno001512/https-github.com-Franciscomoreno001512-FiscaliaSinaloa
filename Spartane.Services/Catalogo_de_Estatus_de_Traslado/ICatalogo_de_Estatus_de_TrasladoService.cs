using System;
using Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Catalogo_de_Estatus_de_Traslado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICatalogo_de_Estatus_de_TrasladoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_TrasladoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Catalogo_de_Estatus_de_Traslado.Catalogo_de_Estatus_de_Traslado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
