using System;
using Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Indicios_de_Diligencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Indicios_de_DiligenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_DiligenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Indicios_de_Diligencia.Detalle_de_Indicios_de_Diligencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
