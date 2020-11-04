using System;
using Spartane.Core.Domain.Medidas_Cautelares;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Medidas_Cautelares
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMedidas_CautelaresService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Medidas_Cautelares.Medidas_CautelaresPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Medidas_Cautelares.Medidas_Cautelares> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
