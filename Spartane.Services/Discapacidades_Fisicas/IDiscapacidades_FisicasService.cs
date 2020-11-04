using System;
using Spartane.Core.Domain.Discapacidades_Fisicas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Discapacidades_Fisicas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDiscapacidades_FisicasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_FisicasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Discapacidades_Fisicas.Discapacidades_Fisicas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
