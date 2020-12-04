using System;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Medios_Prueba_Admitidos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Medios_Prueba_AdmitidosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_AdmitidosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Admitidos.Detalle_Medios_Prueba_Admitidos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
