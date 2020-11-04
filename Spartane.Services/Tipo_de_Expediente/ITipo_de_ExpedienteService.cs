using System;
using Spartane.Core.Domain.Tipo_de_Expediente;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Expediente
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_ExpedienteService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_ExpedientePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Expediente.Tipo_de_Expediente> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
