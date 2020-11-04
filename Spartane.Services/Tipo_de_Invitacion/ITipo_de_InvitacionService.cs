using System;
using Spartane.Core.Domain.Tipo_de_Invitacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Invitacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_InvitacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_InvitacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Invitacion.Tipo_de_Invitacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
