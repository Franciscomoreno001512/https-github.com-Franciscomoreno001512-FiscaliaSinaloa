using System;
using Spartane.Core.Domain.Tamano_Orejas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tamano_Orejas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITamano_OrejasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tamano_Orejas.Tamano_OrejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tamano_Orejas.Tamano_Orejas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
