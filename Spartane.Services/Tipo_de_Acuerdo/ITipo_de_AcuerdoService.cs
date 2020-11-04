using System;
using Spartane.Core.Domain.Tipo_de_Acuerdo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Acuerdo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_AcuerdoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_AcuerdoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Acuerdo.Tipo_de_Acuerdo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
