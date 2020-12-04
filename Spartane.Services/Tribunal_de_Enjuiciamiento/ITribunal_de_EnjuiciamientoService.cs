using System;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tribunal_de_Enjuiciamiento
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITribunal_de_EnjuiciamientoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
