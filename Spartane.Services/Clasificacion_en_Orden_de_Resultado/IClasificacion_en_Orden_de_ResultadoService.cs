using System;
using Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Clasificacion_en_Orden_de_Resultado
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IClasificacion_en_Orden_de_ResultadoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_ResultadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Clasificacion_en_Orden_de_Resultado.Clasificacion_en_Orden_de_Resultado> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
