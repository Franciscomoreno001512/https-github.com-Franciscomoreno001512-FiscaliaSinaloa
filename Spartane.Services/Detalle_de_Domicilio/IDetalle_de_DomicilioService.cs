using System;
using Spartane.Core.Domain.Detalle_de_Domicilio;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Domicilio
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_DomicilioService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_DomicilioPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Domicilio.Detalle_de_Domicilio> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
