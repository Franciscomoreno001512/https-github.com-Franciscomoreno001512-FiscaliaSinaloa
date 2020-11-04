using System;
using Spartane.Core.Domain.Tamano_de_Cejas;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tamano_de_Cejas
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITamano_de_CejasService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_CejasPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tamano_de_Cejas.Tamano_de_Cejas> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
