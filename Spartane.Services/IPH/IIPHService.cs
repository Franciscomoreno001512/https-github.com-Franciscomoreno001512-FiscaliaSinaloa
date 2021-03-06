﻿using System;
using Spartane.Core.Domain.IPH;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.IPH
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IIPHService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.IPH.IPH> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.IPH.IPH> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.IPH.IPH> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.IPH.IPH GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.IPH.IPH entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.IPH.IPH entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.IPH.IPH> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.IPH.IPH> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.IPH.IPHPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.IPH.IPH> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
