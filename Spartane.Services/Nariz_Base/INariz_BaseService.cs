using System;
using Spartane.Core.Domain.Nariz_Base;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Nariz_Base
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface INariz_BaseService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Nariz_Base.Nariz_Base GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Nariz_Base.Nariz_Base entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Nariz_Base.Nariz_Base entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Nariz_Base.Nariz_BasePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Nariz_Base.Nariz_Base> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
