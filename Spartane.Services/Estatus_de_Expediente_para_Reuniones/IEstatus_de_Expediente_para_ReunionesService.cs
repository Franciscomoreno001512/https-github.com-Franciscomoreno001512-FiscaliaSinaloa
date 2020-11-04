using System;
using Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Estatus_de_Expediente_para_Reuniones
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IEstatus_de_Expediente_para_ReunionesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_ReunionesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Estatus_de_Expediente_para_Reuniones.Estatus_de_Expediente_para_Reuniones> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
