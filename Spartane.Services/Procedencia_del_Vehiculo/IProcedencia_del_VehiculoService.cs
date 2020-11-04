using System;
using Spartane.Core.Domain.Procedencia_del_Vehiculo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Procedencia_del_Vehiculo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IProcedencia_del_VehiculoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Procedencia_del_Vehiculo.Procedencia_del_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
