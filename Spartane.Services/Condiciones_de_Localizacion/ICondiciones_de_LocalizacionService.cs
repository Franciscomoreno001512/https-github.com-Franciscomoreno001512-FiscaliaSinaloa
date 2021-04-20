using System;
using Spartane.Core.Domain.Condiciones_de_Localizacion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Condiciones_de_Localizacion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICondiciones_de_LocalizacionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_LocalizacionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Condiciones_de_Localizacion.Condiciones_de_Localizacion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
