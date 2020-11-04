using System;
using Spartane.Core.Domain.Motivo_de_no_Acuerdo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Motivo_de_no_Acuerdo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMotivo_de_no_AcuerdoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_AcuerdoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Motivo_de_no_Acuerdo.Motivo_de_no_Acuerdo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
