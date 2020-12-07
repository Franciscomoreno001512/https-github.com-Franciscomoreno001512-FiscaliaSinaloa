using System;
using Spartane.Core.Domain.Generador_de_NUAT;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Generador_de_NUAT
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IGenerador_de_NUATService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUATPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Generador_de_NUAT.Generador_de_NUAT> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
