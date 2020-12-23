using System;
using Spartane.Core.Domain.Direccion_Exacta;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Direccion_Exacta
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDireccion_ExactaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Direccion_Exacta.Direccion_ExactaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Direccion_Exacta.Direccion_Exacta> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
