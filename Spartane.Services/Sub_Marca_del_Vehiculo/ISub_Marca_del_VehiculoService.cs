using System;
using Spartane.Core.Domain.Sub_Marca_del_Vehiculo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Sub_Marca_del_Vehiculo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ISub_Marca_del_VehiculoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Sub_Marca_del_Vehiculo.Sub_Marca_del_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
