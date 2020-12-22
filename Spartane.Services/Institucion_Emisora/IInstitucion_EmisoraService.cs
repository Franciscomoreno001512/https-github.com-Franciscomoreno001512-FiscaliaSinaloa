using System;
using Spartane.Core.Domain.Institucion_Emisora;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Institucion_Emisora
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IInstitucion_EmisoraService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Institucion_Emisora.Institucion_EmisoraPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Institucion_Emisora.Institucion_Emisora> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
