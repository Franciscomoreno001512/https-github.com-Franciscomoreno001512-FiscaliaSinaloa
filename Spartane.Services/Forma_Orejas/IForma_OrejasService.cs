using System;
using Spartane.Core.Domain.Forma_Orejas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Forma_Orejas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IForma_OrejasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Forma_Orejas.Forma_Orejas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Forma_Orejas.Forma_Orejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Forma_Orejas.Forma_Orejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Forma_Orejas.Forma_OrejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Forma_Orejas.Forma_Orejas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
