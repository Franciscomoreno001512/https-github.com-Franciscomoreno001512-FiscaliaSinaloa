using System;
using Spartane.Core.Domain.Tipo_de_Urgencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Urgencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_UrgenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_UrgenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Urgencia.Tipo_de_Urgencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
