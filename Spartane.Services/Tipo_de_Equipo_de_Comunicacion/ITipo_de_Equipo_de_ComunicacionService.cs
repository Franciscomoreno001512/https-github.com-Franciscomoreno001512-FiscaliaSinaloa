using System;
using Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Equipo_de_Comunicacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_Equipo_de_ComunicacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_ComunicacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Equipo_de_Comunicacion.Tipo_de_Equipo_de_Comunicacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
