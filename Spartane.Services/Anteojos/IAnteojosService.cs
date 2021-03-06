﻿using System;
using Spartane.Core.Domain.Anteojos;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Anteojos
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IAnteojosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Anteojos.Anteojos GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Anteojos.Anteojos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Anteojos.Anteojos entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Anteojos.Anteojos> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Anteojos.Anteojos> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Anteojos.AnteojosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Anteojos.Anteojos> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
