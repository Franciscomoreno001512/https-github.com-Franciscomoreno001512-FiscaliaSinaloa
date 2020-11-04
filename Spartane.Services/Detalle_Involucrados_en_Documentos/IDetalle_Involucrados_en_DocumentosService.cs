using System;
using Spartane.Core.Domain.Detalle_Involucrados_en_Documentos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_Involucrados_en_Documentos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_Involucrados_en_DocumentosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_DocumentosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_Involucrados_en_Documentos.Detalle_Involucrados_en_Documentos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
