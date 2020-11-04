using System;
using Spartane.Core.Domain.Prioridad_del_Hecho;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Prioridad_del_Hecho
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IPrioridad_del_HechoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_HechoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Prioridad_del_Hecho.Prioridad_del_Hecho> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
