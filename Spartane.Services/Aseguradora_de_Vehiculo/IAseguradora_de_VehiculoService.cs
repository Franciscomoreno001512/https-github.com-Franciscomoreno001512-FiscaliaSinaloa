using System;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Aseguradora_de_Vehiculo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAseguradora_de_VehiculoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
