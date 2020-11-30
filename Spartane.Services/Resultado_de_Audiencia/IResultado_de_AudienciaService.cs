using System;
using Spartane.Core.Domain.Resultado_de_Audiencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Resultado_de_Audiencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IResultado_de_AudienciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_AudienciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Resultado_de_Audiencia.Resultado_de_Audiencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
