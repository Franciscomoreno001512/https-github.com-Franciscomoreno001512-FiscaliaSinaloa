using System;
using Spartane.Core.Domain.Detalle_Resumen_Denuncia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Resumen_Denuncia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Resumen_DenunciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_DenunciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Resumen_Denuncia.Detalle_Resumen_Denuncia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
