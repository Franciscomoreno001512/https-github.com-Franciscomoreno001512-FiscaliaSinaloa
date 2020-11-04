using System;
using Spartane.Core.Domain.Senas_Particulares;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Senas_Particulares
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISenas_ParticularesService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Senas_Particulares.Senas_Particulares GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Senas_Particulares.Senas_Particulares entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Senas_Particulares.Senas_ParticularesPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Senas_Particulares.Senas_Particulares> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
