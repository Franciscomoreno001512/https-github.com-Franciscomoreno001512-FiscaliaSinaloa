using System;
using Spartane.Core.Domain.Tipo_de_Funcion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Funcion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_FuncionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_FuncionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Funcion.Tipo_de_Funcion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
