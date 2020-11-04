using System;
using Spartane.Core.Domain.Forma_Cara;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Forma_Cara
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IForma_CaraService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Forma_Cara.Forma_Cara> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Cara.Forma_Cara> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Forma_Cara.Forma_Cara> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Forma_Cara.Forma_Cara GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Forma_Cara.Forma_Cara entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Forma_Cara.Forma_Cara entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Forma_Cara.Forma_Cara> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Forma_Cara.Forma_Cara> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Forma_Cara.Forma_CaraPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Forma_Cara.Forma_Cara> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
