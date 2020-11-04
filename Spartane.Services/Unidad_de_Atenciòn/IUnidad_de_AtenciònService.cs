using System;
using Spartane.Core.Domain.Unidad_de_Atenciòn;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Unidad_de_Atenciòn
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IUnidad_de_AtenciònService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_AtenciònPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Unidad_de_Atenciòn.Unidad_de_Atenciòn> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
