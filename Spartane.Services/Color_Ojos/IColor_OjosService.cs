using System;
using Spartane.Core.Domain.Color_Ojos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Color_Ojos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IColor_OjosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Color_Ojos.Color_Ojos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Color_Ojos.Color_Ojos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Color_Ojos.Color_Ojos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Color_Ojos.Color_OjosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Color_Ojos.Color_Ojos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
