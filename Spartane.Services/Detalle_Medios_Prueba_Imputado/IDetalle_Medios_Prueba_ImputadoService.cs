using System;
using Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Medios_Prueba_Imputado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Medios_Prueba_ImputadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_ImputadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Medios_Prueba_Imputado.Detalle_Medios_Prueba_Imputado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
