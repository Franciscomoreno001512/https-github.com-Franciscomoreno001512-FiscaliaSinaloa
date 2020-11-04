using System;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Modalidad_de_Robo_de_Vehiculo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IModalidad_de_Robo_de_VehiculoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
