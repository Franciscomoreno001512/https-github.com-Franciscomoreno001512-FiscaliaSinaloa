using System;
using Spartane.Core.Domain.Forma_de_Menton;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Forma_de_Menton
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IForma_de_MentonService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Forma_de_Menton.Forma_de_MentonPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Forma_de_Menton.Forma_de_Menton> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
