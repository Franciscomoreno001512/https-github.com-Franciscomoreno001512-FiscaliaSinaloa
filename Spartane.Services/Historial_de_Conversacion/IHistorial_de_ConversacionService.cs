using System;
using Spartane.Core.Domain.Historial_de_Conversacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Historial_de_Conversacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IHistorial_de_ConversacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_ConversacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Historial_de_Conversacion.Historial_de_Conversacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
