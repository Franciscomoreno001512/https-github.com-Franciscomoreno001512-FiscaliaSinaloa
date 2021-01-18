using System;
using Spartane.Core.Domain.Tipo_de_queja_sugerencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_queja_sugerencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_queja_sugerenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_queja_sugerencia.Tipo_de_queja_sugerencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
