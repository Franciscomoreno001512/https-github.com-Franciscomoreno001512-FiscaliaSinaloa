using System;
using Spartane.Core.Domain.Forma_de_Nariz;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Forma_de_Nariz
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IForma_de_NarizService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Forma_de_Nariz.Forma_de_NarizPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Forma_de_Nariz.Forma_de_Nariz> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
