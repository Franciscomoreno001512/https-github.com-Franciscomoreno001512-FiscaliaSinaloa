using System;
using Spartane.Core.Domain.Asignacion_de_Turnos_Previos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Asignacion_de_Turnos_Previos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAsignacion_de_Turnos_PreviosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_PreviosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Asignacion_de_Turnos_Previos.Asignacion_de_Turnos_Previos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
