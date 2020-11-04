using System;
using Spartane.Core.Domain.Estatus_de_Cita_Invitaciones;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_de_Cita_Invitaciones
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_de_Cita_InvitacionesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_InvitacionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_de_Cita_Invitaciones.Estatus_de_Cita_Invitaciones> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
