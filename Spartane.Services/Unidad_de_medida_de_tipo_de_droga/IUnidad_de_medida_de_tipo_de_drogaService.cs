using System;
using Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Unidad_de_medida_de_tipo_de_droga
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IUnidad_de_medida_de_tipo_de_drogaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_drogaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Unidad_de_medida_de_tipo_de_droga.Unidad_de_medida_de_tipo_de_droga> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
