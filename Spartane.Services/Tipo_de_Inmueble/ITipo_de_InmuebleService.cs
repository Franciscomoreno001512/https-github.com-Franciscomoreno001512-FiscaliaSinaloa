using System;
using Spartane.Core.Domain.Tipo_de_Inmueble;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Inmueble
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_InmuebleService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_InmueblePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Inmueble.Tipo_de_Inmueble> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
