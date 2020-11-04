using System;
using Spartane.Core.Domain.Diligencias;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Diligencias
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDiligenciasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Diligencias.Diligencias> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Diligencias.Diligencias> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Diligencias.Diligencias> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Diligencias.Diligencias GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Diligencias.Diligencias entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Diligencias.Diligencias entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Diligencias.Diligencias> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Diligencias.Diligencias> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Diligencias.DiligenciasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Diligencias.Diligencias> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
