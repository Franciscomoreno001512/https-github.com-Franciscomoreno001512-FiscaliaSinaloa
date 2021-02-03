using System;
using Spartane.Core.Domain.Queja_Sugerencia_Ciudadana;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Queja_Sugerencia_Ciudadana
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IQueja_Sugerencia_CiudadanaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_CiudadanaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Queja_Sugerencia_Ciudadana.Queja_Sugerencia_Ciudadana> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
