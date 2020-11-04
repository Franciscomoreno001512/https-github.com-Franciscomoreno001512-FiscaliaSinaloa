using System;
using Spartane.Core.Domain.Adicciones;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Adicciones
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAdiccionesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Adicciones.Adicciones GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Adicciones.Adicciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Adicciones.Adicciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Adicciones.Adicciones> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Adicciones.Adicciones> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Adicciones.AdiccionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Adicciones.Adicciones> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
