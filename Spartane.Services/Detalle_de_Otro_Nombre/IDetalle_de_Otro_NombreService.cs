using System;
using Spartane.Core.Domain.Detalle_de_Otro_Nombre;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Detalle_de_Otro_Nombre
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDetalle_de_Otro_NombreService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_NombrePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Detalle_de_Otro_Nombre.Detalle_de_Otro_Nombre> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
